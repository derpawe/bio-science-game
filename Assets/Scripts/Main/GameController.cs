using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public float playerMaxHealth = 100f;
	public float decrementPlayerHealthValue = 1f;
	
	public float playerCurrentHealth;
	
	private float _playerHealthOriginal;
	
	static GameController instance = null;
	
	// Use this for initialization
	void Start()
	{
		if (instance != null && instance != this)
		{
			Destroy(gameObject);
			print("Duplicate gameController self-destructing!");
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		
		_playerHealthOriginal = playerMaxHealth;
		playerCurrentHealth = playerMaxHealth;
		
		InvokeRepeating("DecrementPlayerHealth", 0.0001f, 1f);
	}
	
	private void DecrementPlayerHealth()
	{
		playerCurrentHealth -= decrementPlayerHealthValue;
	}
	
	public void UpdatePlayerHealth(float health)
	{
	    Debug.Log("Before: " + playerCurrentHealth);
		playerCurrentHealth += health;
        Debug.Log("After: " + playerCurrentHealth);

	}
	
	public void resetLevel()
	{
		playerCurrentHealth = _playerHealthOriginal;
		Application.LoadLevel(Application.loadedLevel);
	}
	
	void OnLevelWasLoaded(int level)
	{
		_playerHealthOriginal = playerCurrentHealth;
	}
}

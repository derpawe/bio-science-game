using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float playerMaxHealth = 100f;
    public float decrementPlayerHealthValue = 1f;

    public float _playerCurrentHealth;

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
        _playerCurrentHealth = playerMaxHealth;

        InvokeRepeating("DecrementPlayerHealth", 0.0001f, 1f);
    }

    private void DecrementPlayerHealth()
    {
        _playerCurrentHealth -= decrementPlayerHealthValue;
    }

    public void UpdatePlayerHealth(float health)
    {
        _playerCurrentHealth += health;
    }

    public void resetLevel()
    {
        _playerCurrentHealth = _playerHealthOriginal;
        Application.LoadLevel(Application.loadedLevel);
    }

    void OnLevelWasLoaded(int level)
    {
        _playerHealthOriginal = _playerCurrentHealth;
    }
}

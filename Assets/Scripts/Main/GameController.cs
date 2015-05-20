using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Slider healthSlider;

    public float playerMaxHealth = 100f;
    public float decrementPlayerHealthValue = 1f;

    private float _playerCurrentHealth;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        _playerCurrentHealth = playerMaxHealth;

        healthSlider.maxValue = playerMaxHealth;
        healthSlider.value = _playerCurrentHealth;

        InvokeRepeating("DecrementPlayerHealth", 0.0001f, 1f);
    }

    private void DecrementPlayerHealth()
    {
        _playerCurrentHealth -= decrementPlayerHealthValue;
        healthSlider.value = _playerCurrentHealth;
    }

    public void UpdatePlayerHealth(float health)
    {
        _playerCurrentHealth += health;
        healthSlider.value = _playerCurrentHealth;
    }
}

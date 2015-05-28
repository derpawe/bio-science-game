using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{

    private GameController _gameController;
    private Slider _healthSlider;

    void Awake()
    {
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        _healthSlider = GetComponent<Slider>();
    }

    // Use this for initialization
    void Start()
    {
        _healthSlider.maxValue = _gameController.playerMaxHealth;
        _healthSlider.value = _gameController.playerCurrentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        _healthSlider.value = _gameController.playerCurrentHealth;

        if (_healthSlider.value <= 0)
        {
            foreach (Transform child in _healthSlider.transform)
            {
                if (child.name == "Fill Area")
                {
                    child.gameObject.SetActive(false);
                }
            }

            _gameController.resetLevel();
        }

    }
}

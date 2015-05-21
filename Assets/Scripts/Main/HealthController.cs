﻿using UnityEngine;
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
	void Start () {
        _healthSlider.maxValue = _gameController.playerMaxHealth;
        _healthSlider.value = _gameController._playerCurrentHealth;
	}
	
	// Update is called once per frame
	void Update () {
        _healthSlider.value = _gameController._playerCurrentHealth;
	}
}
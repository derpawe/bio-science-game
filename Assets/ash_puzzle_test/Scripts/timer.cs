using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Slider timerSlider; 

	public float timeLeft = 10.0f;

    private score_counter _scoreCounter;

	// Use this for initialization
	void Start () {
	
		timerSlider.maxValue = timeLeft;

		timerSlider.value = timeLeft;

	    _scoreCounter = GetComponent<score_counter>();

	}

	public void Update()
	{
		timeLeft -= Time.deltaTime;
		
		if (timeLeft <= 0.0f)
		{
		    StartCoroutine(_scoreCounter.playPuzzleTimeOutAudioClip());
		}
		else
		{
			//Debug.Log("Time left = " + (int)timeLeft + " seconds");
		}

		timerSlider.value = timeLeft;
		
	}

	public void DecreaseTime() {
	
		timeLeft += -1f;
	}

}
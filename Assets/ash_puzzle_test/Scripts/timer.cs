using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Slider timerSlider; 

	public float timeLeft = 10.0f;

	// Use this for initialization
	void Start () {
	
		timerSlider.maxValue = timeLeft;

		timerSlider.value = timeLeft;

	}

	public void Update()
	{
		timeLeft -= Time.deltaTime;
		
		if (timeLeft <= 0.0f)
		{
			// End the level here.
			Debug.Log("You ran out of time");
			Application.LoadLevel(Application.loadedLevel);
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
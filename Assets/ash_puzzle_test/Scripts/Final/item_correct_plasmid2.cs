﻿using UnityEngine;
using System.Collections;

public class item_correct_plasmid2 : MonoBehaviour {
	
	public GameObject scoreCounter;

	public bool correctselect2;

	void Start () {

		correctselect2 = false;
		scoreCounter = GameObject.FindGameObjectWithTag("PuzzleController");
	}
	
	void Update() {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>();
		Debug.Log ("Score." + scorecnt.score);	
		scorecnt.score += 1;
		Debug.Log ("Score: " + scorecnt.score);
		Debug.Log("Clicked the correct item on plasmid 2.");

		correctselect2 = true;
		
	}
}
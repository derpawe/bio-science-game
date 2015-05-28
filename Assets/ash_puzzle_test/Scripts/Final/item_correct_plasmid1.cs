using UnityEngine;
using System.Collections;

public class item_correct_plasmid1 : MonoBehaviour {
	
	public GameObject scoreCounter;

	public bool correctselect1;

	void Start () {

		scoreCounter = GameObject.FindGameObjectWithTag("PuzzleController");
	}
	
	// Update is called once per frame
	void Update() {
		
	}
	
	void OnMouseDown() {
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>(); 
		Debug.Log ("Score." + scorecnt.score);
		scorecnt.score += 1;
		Debug.Log ("Score: " + scorecnt.score);
		Debug.Log("Clicked the correct item on plasmid 1.");

		correctselect1 = true;
	}	
}
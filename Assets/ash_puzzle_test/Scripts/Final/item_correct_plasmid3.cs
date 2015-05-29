using UnityEngine;
using System.Collections;

public class item_correct_plasmid3 : MonoBehaviour {
	
	public GameObject scoreCounter;

	public bool correctselect3;
	
	void Start () {
		scoreCounter = GameObject.FindGameObjectWithTag("PuzzleController");
	}
	
	void Update() {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>();
        scorecnt.playCorrectPlasmidAudioClip();
		Debug.Log ("Score." + scorecnt.score);
		scorecnt.score += 1;
		Debug.Log ("Score: " + scorecnt.score);
		Debug.Log("Clicked the correct item on plasmid 3.");

		correctselect3 = true;
		
	}
}

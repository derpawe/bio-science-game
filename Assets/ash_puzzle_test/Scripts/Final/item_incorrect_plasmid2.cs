using UnityEngine;
using System.Collections;

public class item_incorrect_plasmid2 : MonoBehaviour {
	
	public GameObject scoreCounter;
	
	void Start () {
	
		scoreCounter = GameObject.FindGameObjectWithTag("PuzzleController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>(); 
		
		
		scorecnt.score -= 1;
		Debug.Log ("Score: " + scorecnt.score);
		
	}
}

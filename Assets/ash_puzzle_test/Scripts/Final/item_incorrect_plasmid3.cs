using UnityEngine;
using System.Collections;

public class item_incorrect_plasmid3 : MonoBehaviour {
	
	public GameObject scoreCounter;
	
	void Start () {

		scoreCounter = GameObject.FindGameObjectWithTag("PuzzleController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		
		timer timer = scoreCounter.GetComponent<timer> ();

        score_counter scorecnt = scoreCounter.GetComponent<score_counter>();
        scorecnt.playWrongPlasmidAudioClip();
		
		timer.DecreaseTime ();
		
	}
}

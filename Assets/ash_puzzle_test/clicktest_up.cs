using UnityEngine;
using System.Collections;

public class clicktest_up : MonoBehaviour {

	public GameObject scoreCounter;

	
	public static bool correctitem_up;
	
	void Start () {

		correctitem_up = false;
		scoreCounter = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>(); 
		
		if (correctitem_up == true)
		{
			scorecnt.score += 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
		if (correctitem_up == false)
		{
			scorecnt.score -= 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
	}
}

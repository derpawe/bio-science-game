using UnityEngine;
using System.Collections;

public class clicktest_right : MonoBehaviour {
	
	public GameObject scoreCounter;
	
	
	public static bool correctitem_right;
	
	void Start () {
		
		correctitem_right = false;
		scoreCounter = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>(); 
		
		if (correctitem_right == true)
		{
			scorecnt.score += 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
		if (correctitem_right == false)
		{
			scorecnt.score -= 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
	}
}

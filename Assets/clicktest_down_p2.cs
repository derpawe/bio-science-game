using UnityEngine;
using System.Collections;

public class clicktest_down_p2 : MonoBehaviour {
	
	public GameObject scoreCounter;
	
	public static bool correctitem_left;
	
	void Start () {
		
		correctitem_left = false;
		scoreCounter = GameObject.FindGameObjectWithTag("GameController");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>(); 
		
		if (correctitem_left == true)
		{
			scorecnt.score += 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
		if (correctitem_left == false)
		{
			scorecnt.score -= 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
		
	}
}
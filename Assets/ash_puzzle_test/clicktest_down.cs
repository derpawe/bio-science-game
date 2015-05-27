using UnityEngine;
using System.Collections;

public class clicktest_down : MonoBehaviour {
	
	public GameObject scoreCounter;
	
	
	public static bool correctitem_down;
	
	void Start () {
		
		correctitem_down = false;
		scoreCounter = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown() {
		
		score_counter scorecnt = scoreCounter.GetComponent<score_counter>(); 
		
		if (correctitem_down == true)
		{
			scorecnt.score += 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
		if (correctitem_down == false)
		{
			scorecnt.score -= 1;
			Debug.Log ("Score: " + scorecnt.score);
		}
		
	}
}

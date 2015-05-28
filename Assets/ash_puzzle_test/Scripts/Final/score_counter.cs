using UnityEngine;
using System.Collections;

	public class score_counter : MonoBehaviour {

	public int score;
	public bool complete;
    private GameController _gameController;

	public GameObject item_correct_plasmid1;
	public GameObject item_correct_plasmid2;
	public GameObject item_correct_plasmid3;


	void Awake(){
        _gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

	}


		// Use this for initialization
	void Start () {
		score = 0;


	}


	void Checker (){
		bool check1 = item_correct_plasmid1.GetComponent<item_correct_plasmid1> ().correctselect1;
		bool check2 = item_correct_plasmid2.GetComponent<item_correct_plasmid2> ().correctselect2;
		bool check3 = item_correct_plasmid3.GetComponent<item_correct_plasmid3> ().correctselect3;
		if ((check1 == true) && (check2 == true) && (check3 == true))
			complete = true;
		//Debug.Log ("Check 1 " + check1.correctselect1 + check2.correctselect2 + check3.correctselect3);
	}
		// Update is called once per frame
	void Update () {

		Checker ();

		if (complete == true) {
			timer timer = GetComponent<timer>();
			float timerleft = timer.timeLeft;

            Debug.Log(timerleft);
		    _gameController.playerCurrentHealth += timerleft;
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
			Debug.Log("Passed the puzzle!");
		}
	
	}
	
}

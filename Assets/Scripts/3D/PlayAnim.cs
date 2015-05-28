using UnityEngine;
using System.Collections;

public class PlayAnim : MonoBehaviour
{

    private Vector3 _lastFramePosition;

	// Use this for initialization
	void Start ()
	{
	    GetComponent<Animation>().wrapMode = WrapMode.Loop;
	    _lastFramePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 currentFramePosition = transform.position;
	    float distance = Vector3.Distance(_lastFramePosition, currentFramePosition);

	    _lastFramePosition = currentFramePosition;
	    float currentSpeed = Mathf.Abs(distance)/Time.deltaTime;

	    if (currentSpeed > 0.1)
	    {
	        GetComponent<Animation>().CrossFade("Run");
            foreach (AnimationState state in GetComponent<Animation>())
            {
                state.speed = 5F;
            }
	    }
	    else
	    {
	        GetComponent<Animation>().CrossFade("Idle");
            foreach (AnimationState state in GetComponent<Animation>())
            {
                state.speed = 1F;
            }
	    }
	}
}

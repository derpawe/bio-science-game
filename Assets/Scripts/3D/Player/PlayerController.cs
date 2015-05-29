using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public AudioClip gotCaughtAudioClip;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "CatchTrigger")
        {
            StartCoroutine(gotCaught());
        }
    }

    IEnumerator gotCaught()
    {
        AudioSource.PlayClipAtPoint(gotCaughtAudioClip, transform.position, 1f);
        Debug.Log("Got Caught");
        yield return new WaitForSeconds(0.5f);

        // reset level
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().resetLevel();

        yield return 0;
    }

}

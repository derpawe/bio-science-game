using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "CatchTrigger")
        {
            // reset level
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().resetLevel();
        }
    }

}

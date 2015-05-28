using UnityEngine;
using System.Collections;

public class DoorTriggerController : MonoBehaviour {

    private GameObject _player;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == _player)
        {
            Debug.Log("LOAD PUZZLE");
            int i = Application.loadedLevel;
            if (Application.levelCount > i + 1)
            {
                Application.LoadLevel(i + 1);
            }
            else
            {
                Application.LoadLevel(0);
            }
        }
    }
}

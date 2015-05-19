using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    private NavMeshAgent _navAgent;
    private GameObject _player;

    void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == _player)
        {
            CatchPlayer();
        }
    }


    private void CatchPlayer()
    {
        _navAgent.SetDestination(_player.transform.position);
    }
}

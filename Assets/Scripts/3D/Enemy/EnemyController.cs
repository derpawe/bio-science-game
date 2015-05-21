using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{

    public float chaseSpeed = 5f;
    public float patrolSpeed = 3.5f;
    public Transform[] patrolPoints;

    private NavMeshAgent _navAgent;
    private GameObject _player;

    private int currentPatrolPoint;
    private bool isChasing = false;

    void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (isChasing)
        {
            CatchPlayer();
        }
        else
        {
            Patrol();
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == _player)
        {
            isChasing = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        _navAgent.Stop();
        isChasing = false;
        _navAgent.SetDestination(patrolPoints[currentPatrolPoint].position);
        _navAgent.Resume();
    }

    private void Patrol()
    {
        _navAgent.speed = patrolSpeed;
        if (_navAgent.remainingDistance == 0)
        {
            if (currentPatrolPoint == patrolPoints.Length - 1)
            {
                currentPatrolPoint = 0;
            }
            else
            {
                currentPatrolPoint++;
            }
            _navAgent.SetDestination(patrolPoints[currentPatrolPoint].position);
        }
    }

    private void CatchPlayer()
    {
        _navAgent.speed = chaseSpeed;
        _navAgent.SetDestination(_player.transform.position);
    }
}

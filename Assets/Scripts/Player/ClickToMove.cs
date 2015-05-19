using JetBrains.Annotations;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    private NavMeshAgent _navAgent;
    private Vector3 _position;

    private void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _position = transform.position;
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToPosition();
        }
    }

    private void MoveToPosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay((Input.mousePosition));

        if (Physics.Raycast(ray, out hit, 1000))
        {
            _position = hit.point;
        }
        _navAgent.SetDestination(_position);
    }
}
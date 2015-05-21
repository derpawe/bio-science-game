using UnityEngine;
using System.Collections;

public class WaypointGizmo : MonoBehaviour {

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }
}

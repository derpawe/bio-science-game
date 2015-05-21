using JetBrains.Annotations;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float distance = 5f;
    public float height = 7f;
    public float heightDamping = 2f;
    public Transform target;


    [UsedImplicitly]
    private void LateUpdate()
    {
        if (!target)
        {
            return;
        }
        // Get current and wanted height
        float wantedHeight = target.position.y + height;
        float currentHeight = transform.position.y;

        // lerp current height to wanted height
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping*Time.deltaTime);

        // Set position to wanted position
        transform.position = target.position;
        transform.position -= Vector3.forward*distance;

        // Set the height of the camera
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        // Always look at the target
        transform.LookAt(target);
    }
}
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3f;
    public Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target != null)
        {
            // Set the target position without changing the Z coordinate
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

            // Smoothly move the camera towards the target position
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
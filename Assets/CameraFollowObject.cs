using UnityEngine;

public class CameraFollowObject : MonoBehaviour {
    public Transform target;
    public Transform target1;
    private Vector3 startingPosition;
    private Vector3 startingPosition1;

    void Start()
    {
        GetComponent<Camera>().transparencySortMode =
            TransparencySortMode.Orthographic;
        // Store the starting position of the target
        startingPosition = target.position;
        startingPosition1 = target1.position;
    }

    void FixedUpdate()
    {
        Vector3 moveVec =
            target.position - GetComponent<Camera>().transform.position;
        moveVec.z = 0f;
        GetComponent<Camera>().transform.position +=
            moveVec * Time.fixedDeltaTime * 4.0f;

        // Check if the target's Y position is less than or equal to -4
        if (target.position.y <= -4f)
        {
            // Reset the target's position to the starting position
            target.position = startingPosition;
            target1.position = startingPosition1;
        }
    }
}

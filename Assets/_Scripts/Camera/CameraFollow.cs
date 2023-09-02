using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // target for the camera to follow
    public float smoothSpeed = 0.125f; // speed of the camera

    private Vector3 offset; // offset of the camera

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position; // set the offset to the difference between the camera and the target
    }

    // LateUpdate is called after Update, to ensure that the player's movement has already been processed
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // set the desired position to the target's position plus the offset
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // set the smoothed position to the linear interpolation between the camera's position and the desired position, using the smooth speed
        transform.position = smoothedPosition; // set the camera's position to the smoothed position
    }
}

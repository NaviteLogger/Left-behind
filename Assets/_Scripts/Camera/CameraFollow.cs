using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // target for the camera to follow

    // Start is called before the first frame update
    void Start()
    {

    }

    // LateUpdate is called after Update, to ensure that the player's movement has already been processed
    void LateUpdate()
    {
        if (target != null)
        {
            // set the camera's position to the player's position
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}

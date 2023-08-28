using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCubeMovement : MonoBehaviour
{
    public float moveForce = 10f;
    public float jumpForce = 5f;

    private Rigidbody rb; //The rigidbody component is used to access the physics of the object

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Get the rigidbody component from the object
    }

    // Update is called once per frame
    void Update()
    {

    }
}

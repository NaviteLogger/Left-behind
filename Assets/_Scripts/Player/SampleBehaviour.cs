using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleBehaviour : MonoBehaviour
{
    public float moveSpeed = 10f;
    public SpriteRenderer spriteRenderer;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = 0;
        float moveY = 0;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.flipX = false;
            moveX = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.flipX = true;
            moveX = 1;
        }

        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed;
        rb.velocity = movement;
    }
}
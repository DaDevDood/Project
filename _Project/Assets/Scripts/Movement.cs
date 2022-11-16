using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float walkSpeed = 4f;
    Rigidbody rb;
    Vector3 movement;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

    }
    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = (new Vector3(movement.x, 0, movement.z)) * walkSpeed * Time.deltaTime;
    }
}

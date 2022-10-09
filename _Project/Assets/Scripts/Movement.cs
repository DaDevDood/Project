using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    float horizontal, vertical;
    float speed = 5f;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        if (plane.Raycast(ray, out distance))
        {
            Vector3 target = ray.GetPoint(distance);
            Vector3 direction = target - transform.position;
            float rotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, rotation, 0);
        }
    }

    void FixedUpdate(){
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical * speed);
    }
}

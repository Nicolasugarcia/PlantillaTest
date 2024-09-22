using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primerParcial : MonoBehaviour
{

    public float speed = 5;
    public static bool lastKeyUp;
    private Rigidbody rb;
    private Vector3 initialPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public virtual void FixedUpdate()
    {
        Movement();
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = initialPosition;
        }
    }
    private void Movement()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(speed * inputX, speed * inputY);
        rb.velocity = movement;
        if (Input.GetKey(KeyCode.W))
        {
            lastKeyUp = true;
        }
        else
        if (Input.GetKey(KeyCode.S))
        {
            lastKeyUp = false;
        }
    }
}

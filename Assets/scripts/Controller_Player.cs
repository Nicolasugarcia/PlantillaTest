using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller_Player : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody rb;

    public GameObject projectile;
    public GameObject missileProjectile;
    public GameObject option;

    internal bool missiles;
    internal float missileCount;
    internal float shootingCount=0;

    public static bool lastKeyUp;

    public delegate void Shooting();
    public event Shooting OnShooting;

    private Renderer render;

    internal GameObject laser;
    private Vector3 initialPosition;

    //private List<Controller_Option> options;

    public static Controller_Player _Player;

    public Text velocidadMostrar;
    



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        missiles = false;
        
        //options = new List<Controller_Option>();
    }

    private void Update()
    {
        ActionInput();
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = initialPosition;
        }
    }

   
    public virtual void FixedUpdate()
    {
        Movement();
    }

    public virtual void ActionInput()
    {
        missileCount -= Time.deltaTime;
        shootingCount -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && shootingCount < 0)
        {
            if (OnShooting != null)
            {
                OnShooting();
            }


            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);


            shootingCount = 0.1f;
        }
    }


    private void Movement()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(speed* inputX,speed * inputY);
        rb.velocity = movement;
        if (Input.GetKey(KeyCode.W))
        {
            lastKeyUp = true;
        }else
        if (Input.GetKey(KeyCode.S))
        {
            lastKeyUp = false;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Controller_Player;

public class primerParcial : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody rb;

    public GameObject projectile;
    public GameObject doubleProjectile;
    public GameObject missileProjectile;
    public GameObject laserProjectile;
    public GameObject option;
    public int powerUpCount = 0;

    internal bool doubleShoot;
    internal bool missiles;
    internal float missileCount;
    internal float shootingCount = 0;
    internal bool forceField;
    internal bool laserOn;

    public static bool lastKeyUp;

    public delegate void Shooting();
    public event Shooting OnShooting;

    private Renderer render;

    internal GameObject laser;

    //private List<Controller_Option> options;

    public static Controller_Player _Player;

  

  

    private Vector3 initialPosition;

   


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        powerUpCount = 0;
        doubleShoot = false;
        missiles = false;
        laserOn = false;
        forceField = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = initialPosition;
        }
        ActionInput();
    }
    public virtual void FixedUpdate()
    {
        Movement();
        
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
    public virtual void ActionInput()
    {
        missileCount -= Time.deltaTime;
        shootingCount -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Backspace) && shootingCount < 0)
        {
            if (OnShooting != null)
            {
                OnShooting();
            }


            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);


            shootingCount = 0.1f;
        }
    }

}

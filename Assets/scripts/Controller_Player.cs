using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public delegate void Shooting();
    public event Shooting OnShooting;

    internal GameObject laser;
    private Vector3 initialPosition;

    //private List<Controller_Option> options;

    public static Controller_Player _Player;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        missiles = false;
        
    }

    private void Update()
    {
        ActionInput();
     
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
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

   



}

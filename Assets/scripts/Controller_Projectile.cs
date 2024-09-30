using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_Projectile : Projectile
{
    public float projectileSpeed;

    public Rigidbody rb;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    
    public override void Update()
    {
        ProjectileDirection();
        base.Update();
    }
    public virtual void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    public virtual void ProjectileDirection()
    {
        rb.velocity = new Vector3(1 * projectileSpeed, rb.velocity.y, 0);
    }
}

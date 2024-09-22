﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float xLimit = 220;
    public float yLimit = 220;
    
    virtual public void Update()
    {
        CheckLimits();
    }

    internal virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") )
        {
            Destroy(this.gameObject);
        }
    }
    //
    internal virtual void CheckLimits()
    {
        if (this.transform.position.x > xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.x < -xLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.y > yLimit)
        {
            Destroy(this.gameObject);
        }
        if (this.transform.position.y < -yLimit)
        {
            Destroy(this.gameObject);
        }

    }

}

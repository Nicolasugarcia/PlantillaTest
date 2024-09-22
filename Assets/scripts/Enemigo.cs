using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public float speed = 2f;
    public float limite1 = 7f;
    public float limite2 = -7f;
    private Vector3 direccion1 = Vector3.down;
   
    void Start()
    {

    }

    void Update()
    {
        MoverArribaAbajo();
       
    }
    private void MoverArribaAbajo()
    {

        transform.Translate(direccion1 * speed * Time.deltaTime);
        if (transform.position.y < limite2)
        {
            direccion1 = Vector3.up;
        }
        else if (transform.position.y > limite1)
        {
            direccion1 = Vector3.down;
        }
    }
   
}

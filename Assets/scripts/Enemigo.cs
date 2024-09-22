using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed = 2f; 
    public float limite1 = 5f; 
    public float limite2 = -5f; 
    private Vector3 direccion1 = Vector3.down;
    private Vector3 direccion2 = Vector3.left;
    void Start()
    {
        
    }

    void Update()
    {
        MoverArribaAbajo();
        MoverIzqDer();
    }
    private void MoverArribaAbajo()
    {
       
        transform.Translate(direccion1 * speed * Time.deltaTime);
        if (transform.position.y <= limite1)
        {
            direccion1 = Vector3.up; 
        }
        else if (transform.position.y >= limite2)
        {
            direccion1 = Vector3.down; 
        }
    }
    private void MoverIzqDer()
    {

        transform.Translate(direccion2 * speed * Time.deltaTime);
        if (transform.position.x <= limite1)
        {
            direccion1 = Vector3.right;
        }
        else if (transform.position.x >= limite2)
        {
            direccion1 = Vector3.left;
        }
    }
}

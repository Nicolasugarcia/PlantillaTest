using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public Transform player; // Referencia al jugador
    public float speed = 3f; // Velocidad de movimiento del enemigo

    void Update()
    {
        MoveTowardsPlayer();
    }

    private void MoveTowardsPlayer()
    {
        
        Vector3 direction = (player.position - transform.position).normalized;

        
        transform.position += direction * speed * Time.deltaTime;
    }

}

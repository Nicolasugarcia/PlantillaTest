using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    public Transform player; 
    public float speed = 3f; 
    private Vector3 initialPosition;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        MoveTowardsPlayer();
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void MoveTowardsPlayer()
    {
        
        Vector3 direction = (player.position - transform.position).normalized;

        
        transform.position += direction * speed * Time.deltaTime;
    }

}

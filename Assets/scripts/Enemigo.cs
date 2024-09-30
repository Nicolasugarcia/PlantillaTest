using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    public Transform player; // Referencia al jugador
    public float speed = 3f; // Velocidad de movimiento del enemigo
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
    private void OnCollisionEnter(Collision collision)
    {
        // Si el enemigo colisiona con el jugador
        if (collision.gameObject.CompareTag("Power"))
        {
            Destroy(this.gameObject);

        }
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Necesario para trabajar con TextMeshPro

public class PlayerHealthTMP : MonoBehaviour
{
    public int playerHealth = 100; // Vida inicial del jugador
    public TextMeshProUGUI healthText; // Referencia al texto de TextMeshPro UI
    private Vector3 initialPosition;

    void Start()
    {
        UpdateHealthText();
        initialPosition = transform.position;
    }

    // Método que se llama cuando ocurre una colisión
    void OnCollisionEnter(Collision collision)
    {
        // Si colisiona con un objeto que tiene la etiqueta "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 20;
            UpdateHealthText();
            transform.position = initialPosition;
            if (playerHealth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Debug.Log("Game Over");
              
            }
        }
    }
    void UpdateHealthText()
    {
        healthText.text = "Vida del Jugador: " + playerHealth.ToString();
    }
}
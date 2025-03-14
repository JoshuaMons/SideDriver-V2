using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector3 direction;

    public float jumpForce = 10f;
    public float gravity = 20f;

    public GameObject explosionEffect; // Sleep hier je particle prefab in!

    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void Update()
    {
        direction += gravity * Time.deltaTime * Vector3.down;

        if (character.isGrounded)
        {
            direction = Vector3.down;

            if (Input.GetButton("Jump")) {
                direction = Vector3.up * jumpForce;
            }
        }

        character.Move(direction * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.CompareTag("Coin")) {
        //     GameManager.Instance.Coin();
        //     Destroy(other.gameObject);
        // } 
        
        if (other.CompareTag("Obstacle")) {
            Explode(); 
            GameManager.Instance.GameOver();
            Destroy(gameObject); 
        }
    }

    void Explode()
    {
        // Spawn het particle effect op de huidige positie
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
    }
}

using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float rotateSpeed = 180f; // degrees/sec
    [SerializeField] int health = 3;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            health -= 1;
            Debug.Log("Hit! Health = " + health);
            if (health <= 0)
            { 
                Debug.Log("Game Over!");
                // Reset or reload scene
            }
        }
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, moveY, 0f);
        transform.Translate(move *  moveSpeed * Time.deltaTime);

        if (moveX != 0)
        {
            float rottion = moveX * rotateSpeed * Time.deltaTime;
            transform.Rotate(0f, 0f, 0f);
        }
    }
}

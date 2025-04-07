using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float playerDirectionY = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(0, playerDirectionY * playerSpeed);
    }
}
// {
//     public float playerSpeed;
//     private Rigidbody2D rb;
//     private Vector2 playerDirection;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float directionY = Input.GetAxisRaw("Vertical");
//         playerDirection = new Vector2(0, directionY).normalized;
//     }
//     void FixedUpdate()
//     {
//         rb.linearVelocity = new Vector2(0, playerDirection.y * playerSpeed);
//     }
// }

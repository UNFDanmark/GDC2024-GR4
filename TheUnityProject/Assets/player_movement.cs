using UnityEngine;

public class player_movement : MonoBehaviour
{
    private Rigidbody rb;
    public float playerSpeed = 5;
    public float jumpForce = 10;
    public FeetCollider feetCollider;
    public float sprintingSpeed = 10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        Vector3 movement = rb.velocity;
        movement.x = Input.GetAxisRaw("Horizontal") * playerSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement.x = Input.GetAxisRaw("Horizontal") * sprintingSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && feetCollider.isGrounded)
        {
            movement.y += jumpForce;
        }
            

        rb.velocity = movement;
    }
}

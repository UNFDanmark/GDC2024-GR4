using UnityEngine;

public class player_movement : MonoBehaviour
{
    private Rigidbody rb;
    public float playerSpeed = 5;
    public float jumpForce = 10;
    public FeetCollider feetCollider;
    public float sprintingSpeed = 10;
    public bool canJump = true;
    
    // Daniel variabler
    AudioSource audioSource;
    public AudioClip WalkAudioClip;
    public AudioClip RunAudioClip;
    public AudioClip JumpAudioClip;
    private int lastStatePlayed = 0; // 0=stå, 1=gå, 2=løbe, 3=hop
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        Vector3 movement = rb.velocity;
        movement.x = Input.GetAxisRaw("Horizontal") * playerSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement.x = Input.GetAxisRaw("Horizontal") * sprintingSpeed;
        }

        bool isWalking = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        if (isWalking && Input.GetKey(KeyCode.LeftShift))
        {
            if (lastStatePlayed != 2)
            {
                lastStatePlayed = 2;
                audioSource.clip = RunAudioClip;
                audioSource.Play();
                audioSource.loop = true;
            }
        } else if (isWalking)
        {
            if (lastStatePlayed != 1)
            {
                lastStatePlayed = 1;
                audioSource.clip = WalkAudioClip;
                audioSource.Play();
                audioSource.loop = true;
            }
        }
        else
        {
            audioSource.loop = false;
            lastStatePlayed = 0;
        }
        

        if (Input.GetKeyDown(KeyCode.Space) && feetCollider.isGrounded && canJump)
        {
            audioSource.PlayOneShot(JumpAudioClip);
            // lastStatePlayed = 3;
            movement.y += jumpForce;
            // audioSource.clip = JumpAudioClip;
            // audioSource.Play();
            // audioSource.loop = false;
        }
            

        rb.velocity = movement;
    }
}

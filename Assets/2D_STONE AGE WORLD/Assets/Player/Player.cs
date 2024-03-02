using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private Animator animator2;
    public float speed = 5f;
    public float jumpForce = 1000f;

    AudioManager manager;

    private CameraFollow cameraFollow;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        animator = transform.Find("Body").GetComponent<Animator>();
        animator2 = transform.Find("Wood_Club_0000").GetComponent<Animator>();

        if (animator == null)
        {
            Debug.LogError("Animator not found on the 'Body' object.");
        }

        cameraFollow = Camera.main.GetComponent<CameraFollow>();

        if (cameraFollow == null)
        {
            Debug.LogError("CameraFollow script not found on the main camera.");
        }
        else
        {
            cameraFollow.target = transform;
        }
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

        animator.SetBool("isWalking", Mathf.Abs(horizontalInput) > 0);
        animator.SetBool("isRunning", Input.GetKey(KeyCode.LeftShift) && Mathf.Abs(horizontalInput) > 0);

        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            manager.playSFX(manager.jump);
            animator.SetTrigger("isJumping");
            rb.AddForce(new Vector2(0f, jumpForce));
        }

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("isAttacking");
            animator2.SetTrigger("isBatSwing");
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Death"))
        {
            if (!animator.IsInTransition(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    public void ResetToIdleFromAttack()
    {
        animator.ResetTrigger("isAttacking");
    }

    public void ResetToIdleFromJump()
    {
        animator.ResetTrigger("isJumping");
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        return hit.collider != null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadlyBlock"))
        {
            animator.SetTrigger("isDead");
        }
    }
}
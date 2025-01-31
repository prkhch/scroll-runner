using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("설정")]
    [Tooltip("점프력")]
    public float jumpForce;

    [Header("레퍼런스")]
    public Rigidbody2D playerRigidbody;
    public Animator playerAnimator;

    private bool isGrounded = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            playerRigidbody.AddForceY(jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            playerAnimator.SetInteger("state", 1);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "Platform") {

            // 처음 시작할 때는 랜딩 애니메이션 안함
            if(!isGrounded)playerAnimator.SetInteger("state", 2);

            isGrounded = true;
        }
    }
}

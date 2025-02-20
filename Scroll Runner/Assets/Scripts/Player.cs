using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("설정")]
    public float moveSpeed;
    public float jumpForce;

    [Header("레퍼런스")]
    public Rigidbody2D playerRigidbody;
    public Animator playerAnimator;
    public Vector2 spawnPoint;

    public TMP_Text speedTestUI;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = spawnPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerAnimator.GetBool("isDead")) // 죽으면 이동멈춤
        {
            Run();
        }

        speedTestUI.text = moveSpeed + "";
    }

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Stage"))
        {
            playerAnimator.SetBool("isGrounded", true); // 착지 후 달리기 애니메이션
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Stage"))
        {
            playerAnimator.SetBool("isGrounded", false); // 떨어질 때 달리기 애니메이션
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("NextPoint")) // 다음 스테이지
        {
            Debug.Log("NextPoint");
            StageManager.Instance.ActivateStage(++StageManager.Instance.selectedStage);
            transform.position = spawnPoint;
            moveSpeed = 0;
        }
        if(collision.gameObject.CompareTag("Jumper")) // 점프대
        {
            Jump();
        }
        if(collision.gameObject.CompareTag("Booster")) // 부스터
        {
            moveSpeed += 50f;
        }
    }

    void OnTriggerStay2D(Collider2D collision) {
    if (collision.CompareTag("FanRight") || collision.CompareTag("FanLeft")) // 바람
    {
        float fanX = collision.transform.position.x;
        float playerX = transform.position.x;
        float distance = Mathf.Max(Mathf.Abs(playerX - fanX), 0.1f);

        float windEffect = collision.CompareTag("FanRight") ? 0.2f : -0.2f;
        moveSpeed += windEffect / (distance * 0.5f) ; // 가까울수록 영향 증가
    }
}

    void OnDeathAnimationEnd()
    {
        playerAnimator.SetBool("isDead", false);
        transform.position = spawnPoint;
        moveSpeed = 0;
    }
    
    void Run()
    {
        playerRigidbody.AddForceX(moveSpeed, ForceMode2D.Force);
    }

    void Jump()
    {
        playerRigidbody.linearVelocity = new Vector2(playerRigidbody.linearVelocityX, 0); // 현재 중력 초기화
        playerRigidbody.AddForceY(jumpForce + (0.1f * moveSpeed), ForceMode2D.Impulse);
    }

}

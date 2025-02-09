using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("설정")]
    public float moveSpeed;

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
        if(!playerAnimator.GetBool("isDead")) // 죽으면 멈춤
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
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
        if (collision.gameObject.CompareTag("NextPoint"))
        {
            Debug.Log("NextPoint");
            StageManager.Instance.ActivateStage(++StageManager.Instance.selectedStage);
            transform.position = spawnPoint;
        }
    }

    void OnDeathAnimationEnd()
    {
        playerAnimator.SetBool("isDead", false);
        transform.position = spawnPoint;
        moveSpeed = 0;
    }

}

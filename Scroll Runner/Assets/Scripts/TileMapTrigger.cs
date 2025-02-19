using UnityEngine;

public class TileMapTrigger : MonoBehaviour
{
    [Header("래퍼런스")]
    public Player playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어 충돌 감지
        {
            PlayerPushOut(collision);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어 충돌 감지
        {
            PlayerPushOut(collision);
        }
    }

    private void PlayerPushOut(Collision2D collision) 
    {
        Vector2 collisionNormal = collision.contacts[0].normal; // 충돌한 방향
        if(Mathf.Abs(collisionNormal.x) > 0.5f) 
        {
            playerScript.moveSpeed *= -0.1f; // 이동 방향 반전
            playerScript.moveSpeed -= 0.1f; // 이동 방향 반전
        }
    }
}

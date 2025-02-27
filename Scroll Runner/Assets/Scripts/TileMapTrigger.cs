using UnityEngine;

public class TileMapTrigger : MonoBehaviour
{
    [Header("래퍼런스")]
    private Player playerScript;
    void Awake()
    {
        GameObject playerObj = GameObject.FindWithTag("Player");
        if(playerObj != null)
        {
            playerScript = playerObj.GetComponent<Player>();
        }
    }
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
            Debug.Log("OnCollisionEnter2D");
            PlayerPushOut(collision);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // 플레이어 충돌 감지
        {
            Debug.Log("OnCollisionStay2D");
            PlayerPushOut(collision);
        }
    }

    private void PlayerPushOut(Collision2D collision) 
    {
        Vector2 collisionNormal = collision.contacts[0].normal; // 충돌한 방향
        if(Mathf.Abs(collisionNormal.x) > 0.5f && Mathf.Abs(collisionNormal.y) < 0.5f) 
        {
            if (collisionNormal.x > 0.5f) // 오른쪽 벽
            {
                playerScript.moveSpeed = -0.5f;
            }
            else if (collisionNormal.x < -0.5f) // 왼쪽 벽
            {
                playerScript.moveSpeed = 0.5f;
            }
        }
    }
}

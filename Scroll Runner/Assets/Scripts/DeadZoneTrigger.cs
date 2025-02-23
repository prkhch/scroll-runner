using Unity.VisualScripting;
using UnityEngine;

public class DeadZoneTrigger : MonoBehaviour
{
    private Animator playerAnimator;
    void Awake()
    {
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj != null)
        {
            playerAnimator = playerObj.GetComponent<Animator>();
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

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) 
        {
            playerAnimator.SetBool("isDead", true); // 하트 애니메이션 시작

            // 하트 애니메이션 끝
            // Player.OnDeathAnimationEnd()
            
        }
    }


    
}

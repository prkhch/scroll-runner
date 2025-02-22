using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    [Header("래퍼런스")]
    public Animator portalOutAnimator;
    public Transform outPoint;
    public Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            player.position = outPoint.position;
            portalOutAnimator.SetTrigger("ActivePortal");
        }
    }
    
}

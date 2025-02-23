using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    [Header("래퍼런스")]
    public Animator portalOutAnimator;
    public Transform outPoint;
    private Transform playerTransform;
    void Awake()
    {
        GameObject playerObj = GameObject.FindWithTag("Player");
        if(playerObj != null) 
        {
            playerTransform = playerObj.transform;
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerTransform.position = outPoint.position;
            portalOutAnimator.SetTrigger("ActivePortal");
        }
    }
    
}

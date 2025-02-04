using Unity.VisualScripting;
using UnityEngine;

public class DeadZoneTrigger : MonoBehaviour
{
    public Transform spawnPoint;
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
            collision.gameObject.transform.position = spawnPoint.position;
        }
    }
}

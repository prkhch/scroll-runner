using UnityEngine;

public class JumperTrigger : MonoBehaviour
{
    [Header("래퍼런스")]
    public Animator jumperAnimator;
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
            jumperAnimator.SetTrigger("LiftUp");
        }
    }
}

using UnityEngine;

public class Spawner : MonoBehaviour
{

    [Header("레퍼런스")]
    public Player playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerScript.spawnPoint = transform.position;
    }

    void OnEnable()
    {
        playerScript.spawnPoint = transform.position;
    }


}

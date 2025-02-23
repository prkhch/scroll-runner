using UnityEngine;

public class Spawner : MonoBehaviour
{

    [Header("레퍼런스")]
    private Player playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        GameObject playerObj = GameObject.FindWithTag("Player");
        if (playerObj != null)
        {
            playerScript = playerObj.GetComponent<Player>();
        }

        playerScript.spawnPoint = transform.position;
    }

    void OnEnable()
    {
        playerScript.spawnPoint = transform.position;
    }


}

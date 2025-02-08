using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance { get; private set; }
    public GameObject[] stageArray;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActivateStage(GameManager.Instance.selectedStage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateStage(int stageNumber)
    {
        for (int i = 1; i < stageArray.Length; i++)
        {
            if(i == stageNumber) 
            {
                stageArray[i].SetActive(true);
            } else 
            {
                stageArray[i].SetActive(false);
            }
        }
    }
}

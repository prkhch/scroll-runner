using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int selectedStage;
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

    public void LoadStageScene(int stageNumber)
    {
        selectedStage = stageNumber;
        Debug.Log("Loading Stage: " + stageNumber);
        SceneManager.LoadScene("StageScene");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.DeleteAll();  // 모든 PlayerPrefs 초기화
        PlayerPrefs.Save();       // 즉시 저장
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

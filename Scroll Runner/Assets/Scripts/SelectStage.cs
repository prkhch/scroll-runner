using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectStage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("래퍼런스")]
    public Button stageSelectButton;
    void Start()
    {
        if (stageSelectButton != null)
        {
            stageSelectButton.onClick.AddListener(LoadStageScene);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadStageScene()
    {
        SceneManager.LoadScene("StageScene"); // "StageScene"으로 이동
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuEvent : MonoBehaviour
{

    [Header("래퍼런스")]
    public Button menuButtonUI;
    public GameObject pausePanelUI;
    public Button resumeButtonUI;
    public Button exitButtonUI;
    public Button restartButtonUI;
    public Player playerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (menuButtonUI != null)
        {
            menuButtonUI.onClick.AddListener(TogglePausePanel);
        }
        if (resumeButtonUI != null)
        {
            resumeButtonUI.onClick.AddListener(TogglePausePanel);
        }
        if (exitButtonUI != null)
        {
            exitButtonUI.onClick.AddListener(Exit);
        }
        if (restartButtonUI != null)
        {
            restartButtonUI.onClick.AddListener(Restart);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TogglePausePanel()
    {
        pausePanelUI.SetActive(!pausePanelUI.activeSelf);
        if(pausePanelUI.activeSelf) 
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    void Exit()
    {
        Time.timeScale = 1f;
        Destroy(StageManager.Instance.gameObject);
        SceneManager.LoadScene("MainScene");
    }

    void Restart()
    {
        Time.timeScale = 1f;
        TogglePausePanel();
        playerScript.OnDeathAnimationEnd();
    }

}

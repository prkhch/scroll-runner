using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectStage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("시작")]
    public GameObject startPanelUI;
    public Button runButton;
    [Header("스테이지선택")]
    public GameObject selectStagePanelUI;
    public Button closeButton;
    public Button selectStageButton;
    private int selectedStage;
    void Start()
    {
        if (runButton != null)
        {
            runButton.onClick.AddListener(ToggleSelectStagePanel);
        }
        if (closeButton != null)
        {
            closeButton.onClick.AddListener(ToggleSelectStagePanel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadStageScene()
    {
        // SceneManager.LoadScene("StageScene"); // "StageScene"으로 이동
        
    }
    
    void ToggleSelectStagePanel() {
        startPanelUI.SetActive(!startPanelUI.activeSelf);
        selectStagePanelUI.SetActive(!selectStagePanelUI.activeSelf);
    }
}

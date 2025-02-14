using UnityEngine;
using UnityEngine.UI;

public class SelectStageEvent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("시작")]
    public GameObject startPanelUI;
    public Button runButton;
    [Header("스테이지선택")]
    public GameObject selectStagePanelUI;
    public Button closeButton;
    public Button[] stageButtonArray;
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
        if (stageButtonArray != null)
        {
            for (int i = 1; i < stageButtonArray.Length; i++)
            {
                int stageNumber = i;
                stageButtonArray[i].onClick.AddListener(() => GameManager.Instance.LoadStageScene(stageNumber)); // i번 버튼 : i번째 스테이지 로드 이벤트
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
    void ToggleSelectStagePanel() {
        startPanelUI.SetActive(!startPanelUI.activeSelf);
        selectStagePanelUI.SetActive(!selectStagePanelUI.activeSelf);
    }
}

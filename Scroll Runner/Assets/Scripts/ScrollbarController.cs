using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarController : MonoBehaviour
{

    [Header("레퍼런스")]
    public Scrollbar scrollbarUI;
    public Player playerScript;

    [Header("설정")]
    public float preValue;
    private float valueBalance;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scrollbarUI.onValueChanged.AddListener(OnScrollbarValueChanged);
        playerScript.moveSpeed = 1;
        valueBalance = 0.7f;
        // StartCoroutine(CantStopPlayer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnScrollbarValueChanged(float value)
    {   
        if (value > preValue)
        {
            playerScript.moveSpeed = Mathf.Min(playerScript.moveSpeed + value * valueBalance, 100); 
        }
        else
        {
            playerScript.moveSpeed = Mathf.Max(playerScript.moveSpeed - value * valueBalance, -100);
        }

        preValue = value;

    }

    // private IEnumerator CantStopPlayer()
    // {
    //     while(true) {
    //         yield return new WaitForSeconds(1f);
    //         if(playerScript.moveSpeed > -0.5f) {     
    //             playerScript.moveSpeed = Mathf.Min(playerScript.moveSpeed + 1, 10);
    //         } else {
    //             playerScript.moveSpeed = 1;
    //         }
    //     }
    // }
    

}

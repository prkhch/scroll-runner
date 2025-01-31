using Unity.Collections;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Header("설정")]
    [Tooltip("배경의 스크롤 속도를 조절합니다.")]
    public float scrollSpeed;

    [Header("레퍼런스")]
    [Tooltip("3D 모델의 외형(재질, 색상 등)을 제어합니다.")]
    public MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}

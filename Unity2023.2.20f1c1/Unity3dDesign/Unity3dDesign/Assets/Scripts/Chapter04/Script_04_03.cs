using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_03 : MonoBehaviour
{
    private void Start()
    {
        //创建一个和屏幕大小一样的Render Texture
        RenderTexture renderTexture = RenderTexture.GetTemporary(Screen.width, Screen.height);
        //设置主摄像机，将渲染结果输出到这张Render Texture中
        Camera.main.targetTexture = renderTexture;
        //将摄像机的渲染结果显示在Raw Image中
        RawImage rawImage = GetComponent<RawImage>();
        rawImage.texture = renderTexture;
        rawImage.enabled = true;
    }
}

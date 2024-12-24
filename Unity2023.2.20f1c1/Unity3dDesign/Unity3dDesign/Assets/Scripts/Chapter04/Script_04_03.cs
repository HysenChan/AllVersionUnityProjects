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
        //����һ������Ļ��Сһ����Render Texture
        RenderTexture renderTexture = RenderTexture.GetTemporary(Screen.width, Screen.height);
        //�����������������Ⱦ������������Render Texture��
        Camera.main.targetTexture = renderTexture;
        //�����������Ⱦ�����ʾ��Raw Image��
        RawImage rawImage = GetComponent<RawImage>();
        rawImage.texture = renderTexture;
        rawImage.enabled = true;
    }
}

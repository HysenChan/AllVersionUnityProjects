using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLogic : MonoBehaviour
{
    private void OnPreCull()
    {
        Debug.Log("������������ü�֮ǰ����");
    }
    private void OnWillRenderObject()
    {
        Debug.Log("������Ե�ǰ������ɼ�ʱ����");
    }
    private void OnBecameVisible()
    {
        Debug.Log("��������κ�������ɼ�ʱ����");
    }
    private void OnBecameInvisible()
    {
        Debug.Log("��������κ���������ɼ�ʱ����");
    }
    private void OnPreRender()
    {
        Debug.Log("�������ʼ��Ⱦ����ǰ����");
    }
    private void OnRenderObject()
    {
        Debug.Log("�������ʼ��Ⱦ���������");
    }
    private void OnPostRender()
    {
        Debug.Log("����������Ⱦ���������");
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Debug.Log("ȫ����Ⱦ��Ϻ����");
    }
}

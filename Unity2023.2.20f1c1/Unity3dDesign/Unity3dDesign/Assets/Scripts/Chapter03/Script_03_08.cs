using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Script_03_08 : MonoBehaviour
{
    //private void Start()
    //{
    //    //����Э������
    //    StartCoroutine(MyFunction());
    //    //�ر�Э��
    //    StopCoroutine(MyFunction());
    //    //�ر�����Я������
    //    StopAllCoroutines();

    //    GetComponent<Script_03_08>().StartCoroutine(MyFunction());

    //    Resources.LoadAsync<Sprite>("icon").completed += (a) =>
    //    {
    //        //�������1
    //    };

    //    Resources.LoadAsync<TextAsset>("text").completed += (a) =>
    //    {
    //        //�������2
    //    };
    //}

    //IEnumerator MyFunction()
    //{
    //    Debug.Log("MyFunction");
    //    yield return null;
    //}

    //IEnumerator Load()
    //{
    //    yield return Resources.LoadAsync<Sprite>("icon");//�������1
    //    yield return Resources.LoadAsync<TextAsset>("text");//�������2
    //    Debug.Log("��ʱ1��2�����������");
    //}

    private int m_CacheValue = -1;
    public void UpdateValue(int value)
    {
        Debug.Log($"��{Time.frameCount}֡���Ը���{value}");
        if (m_CacheValue == -1)
        {
            StartCoroutine(Wait());
        }
        m_CacheValue = value;
    }

    IEnumerator Wait()
    {
        yield return new WaitForEndOfFrame();
        //�����һ�ε�m_CacheValue���к�ʱ����
        Debug.Log($"��{Time.frameCount}֡���մ���ֵ{m_CacheValue}");
        m_CacheValue = -1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //���Խ��ж�θ�ֵ
            UpdateValue(2);
            UpdateValue(3);
        }
    }
}
using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Script_03_08 : MonoBehaviour
{
    private void Start()
    {
        //����Э������
        StartCoroutine(MyFunction());
        //�ر�Э��
        StopCoroutine(MyFunction());
        //�ر�����Я������
        StopAllCoroutines();

        GetComponent<Script_03_08>().StartCoroutine(MyFunction());

        Resources.LoadAsync<Sprite>("icon").completed += (a) =>
        {
            //�������1
        };

        Resources.LoadAsync<TextAsset>("text").completed += (a) =>
        {
            //�������2
        };
    }

    IEnumerator MyFunction()
    {
        Debug.Log("MyFunction");
        yield return null;
    }

    IEnumerator Load()
    {
        yield return Resources.LoadAsync<Sprite>("icon");//�������1
        yield return Resources.LoadAsync<TextAsset>("text");//�������2
        Debug.Log("��ʱ1��2�����������");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewIEnumerator : MonoBehaviour
{
    void Start()
    {
        //Debug.Log("start1");//1
        //StartCoroutine(Test12());
        //Debug.Log("start2");//3

        StartCoroutine(Init());
    }

    IEnumerator Test34()
    {
        Debug.Log("test3");
        yield return null;
        Debug.Log("test4");
    }

    IEnumerator Test12()
    {
        Debug.Log("test1");//2
        //yield return null;
        //yield return new WaitForSeconds(2);//�ȴ�2s֮��test2�Ż����
        //yield return new WaitForFixedUpdate();
        yield return StartCoroutine(Test34());//Test1Эͬ����ִ����֮��test2�Ż����
        Debug.Log("test2");//4
    }

    IEnumerator Init()
    {
        yield return StartCoroutine(init1());
        Debug.Log("init1 finish");
        yield return StartCoroutine(init2());
        Debug.Log("init2 finish");
        yield return StartCoroutine(init3());
        Debug.Log("init3 finish");
    }

    IEnumerator init1()
    {
        // ģ���ʼ��
        yield return new WaitForSeconds(2);//
    }
    IEnumerator init2()
    {
        // do somthing..
        yield return new WaitForSeconds(2);//
    }
    IEnumerator init3()
    {
        // do somthing..
        yield return new WaitForSeconds(2);//
    }
}

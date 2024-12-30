using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class MyEvent : UnityEvent<int, string> { }

public class Script_04_14 : MonoBehaviour
{
    public UnityAction<int, string> action;
    public MyEvent myEvent = new MyEvent();

    public void RunMyEvent1(int a, string b)
    {
        Debug.Log(string.Format("RunMyEvent1,{0},{1}", a, b));
    }

    private void Start()
    {
        //Ҳ����ʹ��+=������+=����ִ�ж��֮�����û�ж�Ӧ��-=���ͻ�������
        action = RunMyEvent1;

        myEvent.AddListener(action);

        //�����Ҫ�޳�����ִ��Remove
        //myEvent.RemoeListener(action);
        //myEvent.RemoveAllListeners();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("����A��");
            action.Invoke(0, "a");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("����B��");
            action.Invoke(100, "a & b");
        }
    }
}
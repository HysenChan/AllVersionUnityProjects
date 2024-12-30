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
        //也可以使用+=，但是+=操作执行多次之后，如果没有对应的-=，就会有隐患
        action = RunMyEvent1;

        myEvent.AddListener(action);

        //如果需要剔除，就执行Remove
        //myEvent.RemoeListener(action);
        //myEvent.RemoveAllListeners();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("按下A键");
            action.Invoke(0, "a");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("按下B键");
            action.Invoke(100, "a & b");
        }
    }
}
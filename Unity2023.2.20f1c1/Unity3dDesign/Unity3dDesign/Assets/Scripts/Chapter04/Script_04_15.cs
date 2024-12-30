using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_15 : MonoBehaviour
{
    //无返回值
    public delegate void MyDelegate(int x, int y);
    public MyDelegate Delegate;
    public Action<int, int> Action;

    //有返回值
    public delegate int MyDelegate2(int x, int y);
    public MyDelegate2 Delegate2;
    public Func<int, int, int> Func;

    private void Awake()
    {
        Delegate += (x, y) => { };
        Action += (x, y) => { };

        Delegate2 += (x, y) =>
        {
            return x + y;
        };
        Func += (x, y) =>
        {
            return x + y;
        };

        //执行
        Delegate?.Invoke(1, 1);
        Action?.Invoke(1, 1);

        //返回值
        int a = Delegate2.Invoke(1, 1);
        int b = Func.Invoke(1, 1);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_13 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        //强制让顶层布局获得焦点
        root.focusable = true;
        root.Focus();
        //监听按下抬起事件
        root.RegisterCallback<KeyDownEvent>(OnKeyDown, TrickleDown.TrickleDown);
        root.RegisterCallback<KeyUpEvent>(OnKeyUp, TrickleDown.TrickleDown);
    }
    void OnKeyDown(KeyDownEvent ev) { }
    void OnKeyUp(KeyUpEvent ev) { }
}

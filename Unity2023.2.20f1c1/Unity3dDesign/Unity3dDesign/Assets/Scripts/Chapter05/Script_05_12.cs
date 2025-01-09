using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_12 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        var textFiled = root.Q<TextField>();
        textFiled.RegisterCallback<FocusOutEvent>((evt) =>
        {
            Debug.Log("失去焦点之前发送");
        });
        textFiled.RegisterCallback<FocusInEvent>((evt) =>
        {
            Debug.Log("获取焦点之前发送");
        });
        textFiled.RegisterCallback<BlurEvent>((evt) =>
        {
            Debug.Log("失去焦点之后发送");
        });
        textFiled.RegisterCallback<FocusEvent>((evt) =>
        {
            Debug.Log("获取焦点之后发送");
        });
    }
}

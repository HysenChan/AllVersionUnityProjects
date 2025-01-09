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
            Debug.Log("ʧȥ����֮ǰ����");
        });
        textFiled.RegisterCallback<FocusInEvent>((evt) =>
        {
            Debug.Log("��ȡ����֮ǰ����");
        });
        textFiled.RegisterCallback<BlurEvent>((evt) =>
        {
            Debug.Log("ʧȥ����֮����");
        });
        textFiled.RegisterCallback<FocusEvent>((evt) =>
        {
            Debug.Log("��ȡ����֮����");
        });
    }
}

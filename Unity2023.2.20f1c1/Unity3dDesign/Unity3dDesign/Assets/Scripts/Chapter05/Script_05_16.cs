using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_16 : MonoBehaviour
{
    public StyleSheet StyleSheet1;
    public StyleSheet StyleSheet2;

    private VisualElement m_Root;
    void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        m_Root = document.rootVisualElement;

        //清空默认样式
        m_Root.styleSheets.Clear();

        m_Root.Q<Button>("style1").clicked += () => {
            SetState(StyleSheet1);
        };
        m_Root.Q<Button>("style2").clicked += () => {
            SetState(StyleSheet2);
        };
    }

    //切换状态
    void SetState(StyleSheet style)
    {
        m_Root.styleSheets.Clear();
        m_Root.styleSheets.Add(style);
    }
}

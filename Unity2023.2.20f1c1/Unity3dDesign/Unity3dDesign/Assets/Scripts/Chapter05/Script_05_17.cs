using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_17 : EditorWindow
{
    [MenuItem("UIToolkit/Script_05_17")]
    public static void ShowExample17()
    {
        EditorWindow wnd = GetWindow<Script_05_17>();
        wnd.titleContent = new GUIContent("ShowExample17");
    }

    public void CreateGUI()
    {
        //���ز����ļ�������ʵ������������
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Resources/Chapter05/05_19_Template.uxml");
        rootVisualElement.Add(visualTree.Instantiate());

        //�����¼�
        rootVisualElement.Q<Button>().clicked += () => { Debug.Log("click"); };
        rootVisualElement.Q<Toggle>().RegisterValueChangedCallback((change) =>
        {
            Debug.Log(change.newValue);
        });
    }
}

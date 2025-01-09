using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_11 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var visualTreeAsset = Resources.Load<VisualTreeAsset>("Chapter05/05_11_Template_Item");
        var template = visualTreeAsset.CloneTree();
        root.Add(template);//克隆到Hierarchy视图中
        template.Q<Label>().text = "更换文字";
    }
}

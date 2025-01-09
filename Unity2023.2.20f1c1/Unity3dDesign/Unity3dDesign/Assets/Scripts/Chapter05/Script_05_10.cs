using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_10 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        //给布局添加一个贴图
        Image image = new Image();
        image.sprite = Resources.Load<Sprite>("Chapter05/Unity_logo");
        image.style.width = 100;
        image.style.height = 200;
        root.Add(image);

        //在贴图节点下添加文字，并且插入到第0个索引的位置
        Label label2 = new Label();
        label2.style.fontSize = 40;
        label2.text = "添加文本2";
        image.hierarchy.Insert(0, label2);
    }
}

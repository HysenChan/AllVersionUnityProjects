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

        //���������һ����ͼ
        Image image = new Image();
        image.sprite = Resources.Load<Sprite>("Chapter05/Unity_logo");
        image.style.width = 100;
        image.style.height = 200;
        root.Add(image);

        //����ͼ�ڵ���������֣����Ҳ��뵽��0��������λ��
        Label label2 = new Label();
        label2.style.fontSize = 40;
        label2.text = "����ı�2";
        image.hierarchy.Insert(0, label2);
    }
}

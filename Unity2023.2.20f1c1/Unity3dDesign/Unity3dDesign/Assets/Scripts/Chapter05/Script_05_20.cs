using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_20 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        var button = root.Q<Button>();

        button.clicked += () =>
        {
            //设置坐标
            button.experimental.animation.TopLeft(new Vector2(500, 300), 1000).Ease(Easing.Linear);
            //设置缩放
            button.experimental.animation.Scale(2f, 1000).Ease(Easing.Linear);
            //设置颜色
            button.experimental.animation.Start(button.style.backgroundColor.value, Color.red, 1000,
                (a, b) =>
                {
                    a.style.backgroundColor = b;
                }).Ease(Easing.Linear);
        };
    }
}

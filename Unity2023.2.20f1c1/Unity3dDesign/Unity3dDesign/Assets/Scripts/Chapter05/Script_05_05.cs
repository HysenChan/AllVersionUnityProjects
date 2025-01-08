using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_05 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        //处理Button组件
        var button = root.Q<Button>();
        button.clicked += () => { Debug.Log("Button Click!"); };

        //处理Toggle组件
        var toggle = root.Q<Toggle>();
        toggle.RegisterValueChangedCallback((value) => { Debug.Log($"toggle valueChange : {value.newValue}"); });

        //处理Scroller组件
        var scroller = root.Q<Scroller>();
        scroller.lowValue = 0;//最小值
        scroller.highValue = 100;//最大值
        scroller.valueChanged += (value) => { Debug.Log($"scroller valueChanged : {value}"); };

        //处理TextField组件
        var textField = root.Q<TextField>();
        textField.isDelayed = true;//输入完毕之后统一回调
        textField.RegisterValueChangedCallback((value) => { Debug.Log($"textField valueChanged : {value.newValue}"); });

        //处理Slider组件
        var slider = root.Q<Slider>("mySlider");
        slider.lowValue = 0;
        slider.highValue = 100;
        slider.RegisterValueChangedCallback((value) => { Debug.Log($"slider valueChanged : {value.newValue}"); });

        //动态设置枚举和监听
        MyEnum myEnum = MyEnum.B;
        //处理EnumField组件
        var enumField = root.Q<EnumField>();
        enumField.Init(myEnum);
        enumField.RegisterValueChangedCallback((value) => { Debug.Log($"enumField valueChanged : {value.newValue}"); });
    }
}

//添加一个自定义枚举
public enum MyEnum
{
    A, B, C
}

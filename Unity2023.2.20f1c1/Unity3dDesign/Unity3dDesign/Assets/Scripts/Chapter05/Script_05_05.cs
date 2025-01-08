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

        //����Button���
        var button = root.Q<Button>();
        button.clicked += () => { Debug.Log("Button Click!"); };

        //����Toggle���
        var toggle = root.Q<Toggle>();
        toggle.RegisterValueChangedCallback((value) => { Debug.Log($"toggle valueChange : {value.newValue}"); });

        //����Scroller���
        var scroller = root.Q<Scroller>();
        scroller.lowValue = 0;//��Сֵ
        scroller.highValue = 100;//���ֵ
        scroller.valueChanged += (value) => { Debug.Log($"scroller valueChanged : {value}"); };

        //����TextField���
        var textField = root.Q<TextField>();
        textField.isDelayed = true;//�������֮��ͳһ�ص�
        textField.RegisterValueChangedCallback((value) => { Debug.Log($"textField valueChanged : {value.newValue}"); });

        //����Slider���
        var slider = root.Q<Slider>("mySlider");
        slider.lowValue = 0;
        slider.highValue = 100;
        slider.RegisterValueChangedCallback((value) => { Debug.Log($"slider valueChanged : {value.newValue}"); });

        //��̬����ö�ٺͼ���
        MyEnum myEnum = MyEnum.B;
        //����EnumField���
        var enumField = root.Q<EnumField>();
        enumField.Init(myEnum);
        enumField.RegisterValueChangedCallback((value) => { Debug.Log($"enumField valueChanged : {value.newValue}"); });
    }
}

//���һ���Զ���ö��
public enum MyEnum
{
    A, B, C
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_06 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var groupBox = root.Q<RadioButtonGroup>();
        //设置默认选中第2个(0开始）
        groupBox.value = 1;
        //监听RadioButton切换事件
        groupBox.RegisterValueChangedCallback((value) => { Debug.Log($"groupBox 新值：{value.newValue} 旧值：{value.previousValue}"); });

        var foldout = root.Q<Foldout>();
        //设置默认收缩
        foldout.value = false;
        //监听变化
        foldout.RegisterValueChangedCallback((value) => { Debug.Log($"foldout valueChanged : {value.newValue}"); });
    }
}

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
        //����Ĭ��ѡ�е�2��(0��ʼ��
        groupBox.value = 1;
        //����RadioButton�л��¼�
        groupBox.RegisterValueChangedCallback((value) => { Debug.Log($"groupBox ��ֵ��{value.newValue} ��ֵ��{value.previousValue}"); });

        var foldout = root.Q<Foldout>();
        //����Ĭ������
        foldout.value = false;
        //�����仯
        foldout.RegisterValueChangedCallback((value) => { Debug.Log($"foldout valueChanged : {value.newValue}"); });
    }
}

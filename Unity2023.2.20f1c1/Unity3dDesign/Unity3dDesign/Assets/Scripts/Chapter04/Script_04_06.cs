using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_06 : MonoBehaviour
{
    public Slider slider;
    public Scrollbar scrollbar;
    public TMP_Dropdown dropdown;
    public TMP_InputField inputField;

    private void Start()
    {
        ///1.Slider
        ///����Sliderȡֵ��Χ����Сֵ/���ֵ

        slider.minValue = 0;
        slider.maxValue = 100;

        slider.onValueChanged.AddListener((value) =>
        {
            Debug.Log($"Slider�����仯ֵ = {value}");
        });

        ///2.Scrollbat
        ///

        scrollbar.onValueChanged.AddListener((value) =>
        {
            Debug.Log($"ScrollBar�����仯ֵ = {value}");
        });

        ///3.TMP_Dropdown
        ///
        dropdown.options = new List<TMP_Dropdown.OptionData>();
        dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "����ѡ��1" });
        dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "����ѡ��2" });
        dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "����ѡ��3" });

        dropdown.onValueChanged.AddListener((index) =>
        {
            Debug.Log($"TMP_Dropdown����ѡ������ = {index}");
        });

        ///4.TMP_InputField
        ///
        inputField.onValueChanged.AddListener((str) =>
        {
            Debug.Log($"TMP_InputField�����ַ�����={str}");
        });

        inputField.onEndEdit.AddListener((str) =>
        {
            Debug.Log($"TMP_InputField�����ַ�������={str}");
        });

        inputField.onEndTextSelection.AddListener((str, i, k) =>
        {
            Debug.Log($"TMP_InputField����ѡ�ַ���={str}��ʼλ��={i}����λ��={k}");
        });

        inputField.onDeselect.AddListener((str) =>
        {
            Debug.Log($"TMP_InputFieldȡ��ѡ�ַ���={str}");
        });
    }
}

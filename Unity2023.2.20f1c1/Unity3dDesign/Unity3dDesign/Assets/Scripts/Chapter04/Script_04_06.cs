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
        ///设置Slider取值范围的最小值/最大值

        slider.minValue = 0;
        slider.maxValue = 100;

        slider.onValueChanged.AddListener((value) =>
        {
            Debug.Log($"Slider滑动变化值 = {value}");
        });

        ///2.Scrollbat
        ///

        scrollbar.onValueChanged.AddListener((value) =>
        {
            Debug.Log($"ScrollBar滚动变化值 = {value}");
        });

        ///3.TMP_Dropdown
        ///
        dropdown.options = new List<TMP_Dropdown.OptionData>();
        dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "下拉选单1" });
        dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "下拉选单2" });
        dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "下拉选单3" });

        dropdown.onValueChanged.AddListener((index) =>
        {
            Debug.Log($"TMP_Dropdown下拉选择索引 = {index}");
        });

        ///4.TMP_InputField
        ///
        inputField.onValueChanged.AddListener((str) =>
        {
            Debug.Log($"TMP_InputField输入字符串中={str}");
        });

        inputField.onEndEdit.AddListener((str) =>
        {
            Debug.Log($"TMP_InputField输入字符串结束={str}");
        });

        inputField.onEndTextSelection.AddListener((str, i, k) =>
        {
            Debug.Log($"TMP_InputField鼠标框选字符串={str}起始位置={i}结束位置={k}");
        });

        inputField.onDeselect.AddListener((str) =>
        {
            Debug.Log($"TMP_InputField取消选字符串={str}");
        });
    }
}

using UnityEditor.Build;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Script_03_07 : MonoBehaviour
{
    //设置字符串的最小和最大显示区域
    [TextArea(5, 10)]
    public string MyStr;

    //限制在0和100之间
    [Range(0, 100)]
    public int a1;

    //限制在0f和100f之间
    [Range(0f, 100f)]
    public float a2;

    //鼠标悬浮提示
    [Tooltip("标记")]
    public string tips;

    //是否包含半透明
    [ColorUsage(false)]
    public Color color;
}

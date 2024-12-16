using UnityEditor.Build;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Script_03_07 : MonoBehaviour
{
    //�����ַ�������С�������ʾ����
    [TextArea(5, 10)]
    public string MyStr;

    //������0��100֮��
    [Range(0, 100)]
    public int a1;

    //������0f��100f֮��
    [Range(0f, 100f)]
    public float a2;

    //���������ʾ
    [Tooltip("���")]
    public string tips;

    //�Ƿ������͸��
    [ColorUsage(false)]
    public Color color;
}

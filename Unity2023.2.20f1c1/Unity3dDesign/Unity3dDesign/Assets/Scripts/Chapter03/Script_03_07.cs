using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

[RequireComponent(typeof(Camera))]
public class Script_03_07 : MonoBehaviour
{
    ////�����ַ�������С�������ʾ����
    //[TextArea(5, 10)]
    //public string MyStr;

    //������0��100֮��
    [RangeInt(0, 100)]
    public int a;

    ////������0f��100f֮��
    //[Range(0f, 100f)]
    //public float a2;

    ////���������ʾ
    //[Tooltip("���")]
    //public string tips;

    ////�Ƿ������͸��
    //[ColorUsage(false)]
    //public Color color;
}

public sealed class RangeIntAttribute : PropertyAttribute
{
    public readonly int min;
    public readonly int max;

    public RangeIntAttribute(int min, int max)
    {
        this.min = min;
        this.max = max;
    }
#if UNITY_EDITOR
    [CustomPropertyDrawer(typeof(RangeIntAttribute))]
    public sealed class RangeIntDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 100;//�������ĸ߶�
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            RangeIntAttribute attribute = this.attribute as RangeIntAttribute;
            property.intValue = Mathf.Clamp(property.intValue, attribute.min, attribute.max);
            EditorGUI.HelpBox(new Rect(position.x, position.y, position.width, 30),
                string.Format("��Χ{0}~{1}", attribute.min, attribute.max), MessageType.Info);

            EditorGUI.PropertyField(new Rect(position.x, position.y + 35, position.width, 20), property, label);
        }
    }
#endif
}

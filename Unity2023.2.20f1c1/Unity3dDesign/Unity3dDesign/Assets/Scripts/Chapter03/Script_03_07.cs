using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

[RequireComponent(typeof(Camera))]
public class Script_03_07 : MonoBehaviour
{
    ////设置字符串的最小和最大显示区域
    //[TextArea(5, 10)]
    //public string MyStr;

    //限制在0和100之间
    [RangeInt(0, 100)]
    public int a;

    ////限制在0f和100f之间
    //[Range(0f, 100f)]
    //public float a2;

    ////鼠标悬浮提示
    //[Tooltip("标记")]
    //public string tips;

    ////是否包含半透明
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
            return 100;//设置面板的高度
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            RangeIntAttribute attribute = this.attribute as RangeIntAttribute;
            property.intValue = Mathf.Clamp(property.intValue, attribute.min, attribute.max);
            EditorGUI.HelpBox(new Rect(position.x, position.y, position.width, 30),
                string.Format("范围{0}~{1}", attribute.min, attribute.max), MessageType.Info);

            EditorGUI.PropertyField(new Rect(position.x, position.y + 35, position.width, 20), property, label);
        }
    }
#endif
}

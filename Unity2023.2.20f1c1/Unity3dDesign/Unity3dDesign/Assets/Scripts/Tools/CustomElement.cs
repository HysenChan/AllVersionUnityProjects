using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Sript_05_12
{
    public class CustomElement : TextElement
    {
        public new class UxmlFactory : UxmlFactory<CustomElement, UxmlTraits> { }
        public new class UxmlTraits : VisualElement.UxmlTraits
        {
            //文本的初始化内容
            UxmlStringAttributeDescription m_String =
                new UxmlStringAttributeDescription { name = "string-attr", defaultValue = "hello<sprite=0>world" };

            public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
            {
                get { yield break; }
            }

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);
                var ate = ve as CustomElement;
                ate.stringAttr = m_String.GetValueFromBag(bag, cc);
                var textElement = (TextElement)ve;
                //在这里设置文本初始化内容
                textElement.text = ate.stringAttr;
                textElement.style.fontSize = 50;
                textElement.style.color = Color.red;
                textElement.enableRichText = true;
                textElement.displayTooltipWhenElided = true;
            }
        }
        public string stringAttr { get; set; }
    }
}

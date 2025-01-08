using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_03 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var label = root.Q<Label>("MyLabel");
        //标记文本可以接受点击
        label.focusable = true;
        label.enableRichText = true;
        label.style.fontSize = 50;
        label.text = "<sprite name=EmojiOne_1>图文混排 <u><link=\"ID_1\">我是下划线</link></u>";
        //整个文本监听点击事件
        label.RegisterCallback<ClickEvent>((evt) => { Debug.Log($"click"); });
        //按下事件获取link的名称
        label.RegisterCallback<PointerDownLinkTagEvent>((evt) => { Debug.Log($"LinkID:{evt.linkID}"); });
    }
}

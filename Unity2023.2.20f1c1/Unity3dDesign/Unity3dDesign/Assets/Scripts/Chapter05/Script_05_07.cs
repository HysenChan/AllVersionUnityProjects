using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_07 : MonoBehaviour
{
    public VisualTreeAsset ItemAsset;
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        ScrollView scrollView = root.Q<ScrollView>();
        for (int i = 0; i < 100; i++)
        {
            TemplateContainer templateContainer = ItemAsset.CloneTree();
            //设置每个高度
            templateContainer.style.height = 100;
            templateContainer.Q<Label>().text = $"我是第{i}个<sprite=3>";
            scrollView.Add(templateContainer);
        }

        var button = root.Q<Button>();
        button.clicked += () =>
        {
            Debug.Log("Button clicked");
            scrollView.ScrollTo(scrollView.ElementAt(5));//跳转到第5个元素
        };
    }
}

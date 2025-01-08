using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_08 : MonoBehaviour
{
    public VisualTreeAsset ItemAsset;
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        //准备数据阶段
        const int itemCount = 10000;
        List<string> items = new List<string>(itemCount);
        for (int i = 0; i <= itemCount; i++)
        {
            items.Add($"我是第{i}个<sprite=3>");
        }

        ListView listView = root.Q<ListView>();

        Func<VisualElement> makeItem = () =>
        {
            //当出现在屏幕上时开始克隆对象
            return ItemAsset.CloneTree();
        };

        //关掉ListView的选择事件
        listView.selectionType = SelectionType.None;
        Action<VisualElement, int> bindItem = (e, i) =>
        {
            //屏幕上的对象已经准备好开始刷新数据
            var label = e.Q<Label>();
            var button = e.Q<Button>("button");
            label.text = listView.itemsSource[i].ToString();
            //因为Button对象是循环使用的，所以每次都要清空之前的监听
            button.clickable = null;
            button.clicked += () => { Debug.Log($"点击了第{i}个按钮对象"); };
        };

        listView.selectedIndicesChanged += (indexes) =>
        {
            //选择某个元素调用
            foreach (var index in indexes)
            {
                Debug.Log($"第{index}个被选择了！");
            }
        };

        //设置每个Item的固定高度
        listView.fixedItemHeight = 100;
        //设置原始数据
        listView.itemsSource = items;
        listView.makeItem = makeItem;
        listView.bindItem = bindItem;

        var button = root.Q<Button>();
        button.clicked += () =>
        {
            Debug.Log("Button clicked");
            listView.ScrollToItem(500);//跳转到第500个元素
        };
    }
}

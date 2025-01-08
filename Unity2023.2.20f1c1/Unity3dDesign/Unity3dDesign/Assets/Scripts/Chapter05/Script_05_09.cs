using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_09 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        var treeView = root.Q<TreeView>();
        treeView.selectionType = SelectionType.Multiple;

        //添加子孙节点
        List<TreeViewItemData<string>> datas = new List<TreeViewItemData<string>>();
        List<TreeViewItemData<string>> child = new List<TreeViewItemData<string>>();
        datas.Add(new TreeViewItemData<string>(0, "A", child));
        child.Add(new TreeViewItemData<string>(1, "B"));
        child.Add(new TreeViewItemData<string>(2, "C"));
        child.Add(new TreeViewItemData<string>(3, "D"));

        treeView.SetRootItems(datas);

        treeView.makeItem = () => new Label() { focusable = true };
        treeView.bindItem = (VisualElement element, int index) =>
            (element as Label).text = treeView.GetItemDataForIndex<string>(index);
        treeView.selectionChanged += (o) => { };
    }
}

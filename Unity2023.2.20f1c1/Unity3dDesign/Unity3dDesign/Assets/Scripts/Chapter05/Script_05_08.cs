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

        //׼�����ݽ׶�
        const int itemCount = 10000;
        List<string> items = new List<string>(itemCount);
        for (int i = 0; i <= itemCount; i++)
        {
            items.Add($"���ǵ�{i}��<sprite=3>");
        }

        ListView listView = root.Q<ListView>();

        Func<VisualElement> makeItem = () =>
        {
            //����������Ļ��ʱ��ʼ��¡����
            return ItemAsset.CloneTree();
        };

        //�ص�ListView��ѡ���¼�
        listView.selectionType = SelectionType.None;
        Action<VisualElement, int> bindItem = (e, i) =>
        {
            //��Ļ�ϵĶ����Ѿ�׼���ÿ�ʼˢ������
            var label = e.Q<Label>();
            var button = e.Q<Button>("button");
            label.text = listView.itemsSource[i].ToString();
            //��ΪButton������ѭ��ʹ�õģ�����ÿ�ζ�Ҫ���֮ǰ�ļ���
            button.clickable = null;
            button.clicked += () => { Debug.Log($"����˵�{i}����ť����"); };
        };

        listView.selectedIndicesChanged += (indexes) =>
        {
            //ѡ��ĳ��Ԫ�ص���
            foreach (var index in indexes)
            {
                Debug.Log($"��{index}����ѡ���ˣ�");
            }
        };

        //����ÿ��Item�Ĺ̶��߶�
        listView.fixedItemHeight = 100;
        //����ԭʼ����
        listView.itemsSource = items;
        listView.makeItem = makeItem;
        listView.bindItem = bindItem;

        var button = root.Q<Button>();
        button.clicked += () =>
        {
            Debug.Log("Button clicked");
            listView.ScrollToItem(500);//��ת����500��Ԫ��
        };
    }
}

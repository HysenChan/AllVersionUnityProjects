using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_04 : MonoBehaviour
{
    //private void Start()
    //{
    //    Button button = GetComponent<Button>();
    //    void onButtonClick()
    //    {
    //        Debug.Log("��ť���");
    //    }
    //    button.onClick.AddListener(onButtonClick);

    //    //�Ƴ���ť����ʱ��
    //    //button.onClick.RemoveListener(onButtonClick);
    //    //�Ƴ����а�ť����ʱ��
    //    //button.onClick.RemoveAllListeners();
    //}

    public Toggle[] toggles;
    private void Start()
    {
        foreach (var toggle in toggles)
        {
            toggle.onValueChanged.AddListener((selected) =>
            {
                Debug.LogFormat("toggle = {0} selected = {1}", toggle.name, selected);
            });
        }
    }
}

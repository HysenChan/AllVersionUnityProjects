using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_04 : MonoBehaviour
{
    private void Start()
    {
        Button button = GetComponent<Button>();
        void onButtonClick()
        {
            Debug.Log("按钮点击");
        }
        button.onClick.AddListener(onButtonClick);

        //移除按钮监听时间
        //button.onClick.RemoveListener(onButtonClick);
        //移除所有按钮监听时间
        //button.onClick.RemoveAllListeners();
    }
}

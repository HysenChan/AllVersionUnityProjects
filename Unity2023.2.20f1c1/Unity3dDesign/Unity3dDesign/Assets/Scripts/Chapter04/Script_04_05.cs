using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_05 : MonoBehaviour
{
    private void Start()
    {
        GetComponent<ScrollRect>().onValueChanged.AddListener((progress) =>
        {
            //ȡֵ��ΧΪ0~1
            Debug.Log($"��ǰ��������{progress}");
        });
    }
}

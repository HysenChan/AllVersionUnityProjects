using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_09 : MonoBehaviour
{
    public int SortingOrder;
    private void Awake()
    {
        var renderer = GetComponent<Renderer>();
        if (renderer)
        {
            renderer.sortingOrder = SortingOrder;
        }
    }
}

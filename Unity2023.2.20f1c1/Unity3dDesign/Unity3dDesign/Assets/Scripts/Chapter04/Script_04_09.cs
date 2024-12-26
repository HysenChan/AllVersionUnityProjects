using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_09 : MonoBehaviour
{
    public Image image;
    private void Awake()
    {
        for (int i = 0; i < 9; i++)
        {
            Instantiate<GameObject>(image.gameObject, transform);
        }
        Debug.Log($"Awake frameCount = {Time.frameCount} Rect = {(transform as RectTransform).sizeDelta}");
    }
    private void Start()
    {
        Debug.Log($"Start frameCount = {Time.frameCount} Rect = {(transform as RectTransform).sizeDelta}");

    }
    private void Update()
    {
        Debug.Log($"Update frameCount = {Time.frameCount} Rect = {(transform as RectTransform).sizeDelta}");
    }
}

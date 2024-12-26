using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_08 : MonoBehaviour
{
    public Image image;
    IEnumerator Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Instantiate<GameObject>(image.gameObject, transform);
        }
        Debug.Log($"Awake frameCount = {Time.frameCount} Rect = {(transform as RectTransform).sizeDelta}");
        yield return new WaitForEndOfFrame();
        Debug.Log($"Start frameCount = {Time.frameCount} Rect = {(transform as RectTransform).sizeDelta}");
    }
}

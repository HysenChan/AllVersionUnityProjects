using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_04 : MonoBehaviour
{
    public Sprite sprite;
    private void Start()
    {
        UIDocument document= GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var visualElement = root.Q<VisualElement>("image");
        visualElement.style.backgroundImage = new StyleBackground(sprite);
    }
}

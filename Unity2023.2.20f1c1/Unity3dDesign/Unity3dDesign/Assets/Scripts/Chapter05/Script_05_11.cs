using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_11 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        var button = root.Q<Button>();
        var label = root.Q<Label>();
        button.Add(label);

        document.rootVisualElement.Add(label);
    }
}

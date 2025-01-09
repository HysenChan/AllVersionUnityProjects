using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_16 : MonoBehaviour
{

    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        root.Q<Button>().AddToClassList("style");
        //root.Q<Button>().RemoveFromClassList("style");
    }
}

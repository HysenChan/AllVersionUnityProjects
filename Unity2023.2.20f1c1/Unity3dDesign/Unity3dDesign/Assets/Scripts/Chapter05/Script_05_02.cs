using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Script_05_02 : MonoBehaviour
{
    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var button = root.Q<Button>("MyButton");
        var image = root.Q<VisualElement>("MyImage");
        button.clicked += () =>
        {
            image.schedule.Execute(() => image.AddToClassList("animation"));
        };
    }
}

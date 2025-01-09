using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Script_05_15 : MonoBehaviour
{
    public Transform Cube3D;
    private VisualElement UI;

    private void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;

        UI = root.Q<VisualElement>("image");
    }

    private void Update()
    {
        UI.transform.position = RuntimePanelUtils.CameraTransformWorldToPanel(UI.panel, Cube3D.position, Camera.main);
    }
}

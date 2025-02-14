using System;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_16 : MonoBehaviour
{
    private void Update()
    {
        Ray ray = new Ray(Vector3.zero, Vector3.one * 10f);
        Ray2D ray2D = new Ray2D(Vector2.zero, Vector2.one * 10);

        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        Debug.DrawRay(ray2D.origin, ray2D.direction, Color.yellow);
    }
}

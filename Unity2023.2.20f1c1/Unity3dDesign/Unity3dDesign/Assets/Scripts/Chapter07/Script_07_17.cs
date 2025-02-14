using System;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_17 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.LogFormat("Raycast:{0} 3D×ø±ê:{1}", hit.collider.name, hit.point);
            }

            RaycastHit[] hits = Physics.RaycastAll(ray);
            foreach (var h in hits)
            {
                Debug.LogFormat("RaycastAll:{0} 3D×ø±ê:{1}", h.collider.name, hit.point);
            }
        }
    }
}

using System;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_14 : MonoBehaviour
{
    public GameObject Go3d;
    public GameObject Go2d;

    private void Update()
    {
        Click3D.Get(Go3d).onClick = (e) =>
        {
            Debug.Log("3D点击事件");
        };
        Click3D.Get(Go3d).onDrag = (e) =>
        {
            Debug.Log("3D拖拽事件");
        };
        Click3D.Get(Go2d).onClick = (e) =>
        {
            Debug.Log("2D点击事件");
        };
        Click3D.Get(Go2d).onDrag = (e) =>
        {
            Debug.Log("2D拖拽事件");
        };
    }
}
public class Click3D : MonoBehaviour, IPointerClickHandler, IDragHandler
{
    public Action<PointerEventData> onClick;
    public Action<PointerEventData> onDrag;
    public static Click3D Get(GameObject go)
    {
        Click3D listener = go.GetComponent<Click3D>();
        if (listener == null)
            listener = go.AddComponent<Click3D>();
        return listener;
    }

    public void OnDrag(PointerEventData eventData)
    {
        onDrag?.Invoke(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        onClick?.Invoke(eventData);
    }
}

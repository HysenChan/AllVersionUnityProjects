using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("鼠标按下碰撞器时调用");
    }

    private void OnMouseUp()
    {
        Debug.Log("鼠标抬起碰撞器时调用");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("鼠标松开碰撞器时调用，执行时机在OnMouseUp之前");
    }

    private void OnMouseEnter()
    {
        Debug.Log("鼠标进入碰撞器时调用");
    }

    private void OnMouseDrag()
    {
        Debug.Log("鼠标拖动碰撞器时调用");
    }

    private void OnMouseExit()
    {
        Debug.Log("鼠标离开碰撞器时调用");
    }

    private void OnMouseOver()
    {
        //Debug.Log("鼠标悬浮在碰撞器上时调用");
    }
}

using System.Data.SqlTypes;
using UnityEngine;

public class Script_07_11 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("按下A键事件");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("保将按下A键事件");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("释放A键事件");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("按下鼠标左键");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("保持按下鼠标左键");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("释放鼠标左键");
        }

        if (Input.touchCount > 0)
        {
            //多点触摸
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    Debug.Log($"第{i}根手指触摸开始");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Moved)
                {
                    Debug.Log($"第{i}根手指触摸发生移动");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Ended)
                {
                    Debug.Log($"第{i}根手指触摸结束");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Canceled)
                {
                    Debug.Log($"第{i}根手指触摸被取消");
                }
                else if (Input.GetTouch(i).phase == TouchPhase.Stationary)
                {
                    Debug.Log($"第{i}根手指触摸但没有移动");
                }
                else if (Input.touchPressureSupported)
                {
                    Debug.LogFormat("3DTouch的力度:{0}", Input.GetTouch(i).pressure);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawSphere(Vector3.zero, 1f);
    //}

    private void OnGUI()
    {
        GUILayout.Label($"<size=30>hello<color=red>world!</color></size>");
    }

    private void OnApplicationPause(bool pause)
    {
        //应用程序暂停/恢复
        Debug.Log($"应用程序{(pause ? "恢复" : "暂停")}");
    }

    private void OnApplicationFocus(bool focus)
    {
        //应用程序拥有/丢失焦点
        Debug.Log($"应用程序{(focus ? "恢复" : "暂停")}");
    }
}

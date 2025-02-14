using System;
using System.Collections;
using System.Data.SqlTypes;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Script_07_20 : MonoBehaviour
{
    public Transform Cube;

    private void Start()
    {
        //目标位置、等待时间、结束回调
        StartCoroutine(MoveTo(Cube, Vector3.one * 2, 2f, () =>
        {
            Debug.Log("移动坐标完毕");
        }));

        StartCoroutine(RotationTo(Cube, Vector3.one * 180f, 2f, () =>
        {
            Debug.Log("旋转坐标完毕");
        }));

        StartCoroutine(ScaleTo(Cube, Vector3.one * 3f, 2f, () =>
        {
            Debug.Log("缩放完毕");
        }));
    }


    public IEnumerator MoveTo(Transform transform, Vector3 end, float seconds, Action finish)
    {
        float time = 0;
        Vector3 start = transform.position;
        var wait = new WaitForEndOfFrame();
        //每帧的移动距离
        while (time < seconds)
        {
            transform.position = Vector3.Lerp(start, end, time / seconds);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = end;
        finish?.Invoke();
    }

    public IEnumerator RotationTo(Transform transform, Vector3 end, float seconds, Action finish)
    {
        float time = 0;
        Vector3 start = transform.eulerAngles;
        var wait = new WaitForEndOfFrame();
        //每帧的移动距离
        while (time < seconds)
        {
            transform.eulerAngles = Vector3.Lerp(start, end, time / seconds);
            time += Time.deltaTime;
            yield return null;
        }
        transform.eulerAngles = end;
        finish?.Invoke();
    }

    public IEnumerator ScaleTo(Transform transform, Vector3 end, float seconds, Action finish)
    {
        float time = 0;
        Vector3 start = transform.localScale;
        var wait = new WaitForEndOfFrame();
        //每帧的移动距离
        while (time < seconds)
        {
            transform.localScale = Vector3.Lerp(start, end, time / seconds);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = end;
        finish?.Invoke();
    }
}

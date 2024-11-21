using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLogic : MonoBehaviour
{
    private void OnPreCull()
    {
        Debug.Log("场景被摄像机裁剪之前调用");
    }
    private void OnWillRenderObject()
    {
        Debug.Log("当物体对当前摄像机可见时调用");
    }
    private void OnBecameVisible()
    {
        Debug.Log("当物体对任何摄像机可见时调用");
    }
    private void OnBecameInvisible()
    {
        Debug.Log("当物体对任何摄像机不可见时调用");
    }
    private void OnPreRender()
    {
        Debug.Log("摄像机开始渲染场景前调用");
    }
    private void OnRenderObject()
    {
        Debug.Log("摄像机开始渲染场景后调用");
    }
    private void OnPostRender()
    {
        Debug.Log("摄像机完成渲染场景后调用");
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Debug.Log("全部渲染完毕后调用");
    }
}

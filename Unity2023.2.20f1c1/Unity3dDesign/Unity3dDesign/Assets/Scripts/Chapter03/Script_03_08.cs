using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Script_03_08 : MonoBehaviour
{
    //private void Start()
    //{
    //    //启动协程任务
    //    StartCoroutine(MyFunction());
    //    //关闭协程
    //    StopCoroutine(MyFunction());
    //    //关闭所有携程任务
    //    StopAllCoroutines();

    //    GetComponent<Script_03_08>().StartCoroutine(MyFunction());

    //    Resources.LoadAsync<Sprite>("icon").completed += (a) =>
    //    {
    //        //加载完成1
    //    };

    //    Resources.LoadAsync<TextAsset>("text").completed += (a) =>
    //    {
    //        //加载完成2
    //    };
    //}

    //IEnumerator MyFunction()
    //{
    //    Debug.Log("MyFunction");
    //    yield return null;
    //}

    //IEnumerator Load()
    //{
    //    yield return Resources.LoadAsync<Sprite>("icon");//加载完成1
    //    yield return Resources.LoadAsync<TextAsset>("text");//加载完成2
    //    Debug.Log("此时1和2都加载完成了");
    //}

    private int m_CacheValue = -1;
    public void UpdateValue(int value)
    {
        Debug.Log($"第{Time.frameCount}帧尝试复制{value}");
        if (m_CacheValue == -1)
        {
            StartCoroutine(Wait());
        }
        m_CacheValue = value;
    }

    IEnumerator Wait()
    {
        yield return new WaitForEndOfFrame();
        //用最后一次的m_CacheValue进行耗时计算
        Debug.Log($"第{Time.frameCount}帧最终处理值{m_CacheValue}");
        m_CacheValue = -1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //尝试进行多次赋值
            UpdateValue(2);
            UpdateValue(3);
        }
    }
}
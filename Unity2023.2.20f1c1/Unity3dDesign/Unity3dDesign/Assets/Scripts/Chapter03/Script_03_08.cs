using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Script_03_08 : MonoBehaviour
{
    private void Start()
    {
        //启动协程任务
        StartCoroutine(MyFunction());
        //关闭协程
        StopCoroutine(MyFunction());
        //关闭所有携程任务
        StopAllCoroutines();

        GetComponent<Script_03_08>().StartCoroutine(MyFunction());

        Resources.LoadAsync<Sprite>("icon").completed += (a) =>
        {
            //加载完成1
        };

        Resources.LoadAsync<TextAsset>("text").completed += (a) =>
        {
            //加载完成2
        };
    }

    IEnumerator MyFunction()
    {
        Debug.Log("MyFunction");
        yield return null;
    }

    IEnumerator Load()
    {
        yield return Resources.LoadAsync<Sprite>("icon");//加载完成1
        yield return Resources.LoadAsync<TextAsset>("text");//加载完成2
        Debug.Log("此时1和2都加载完成了");
    }
}
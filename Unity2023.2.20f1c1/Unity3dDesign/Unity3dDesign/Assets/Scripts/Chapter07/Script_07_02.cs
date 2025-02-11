using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_07_02 : MonoBehaviour
{
    private AsyncOperation m_Async;
    private void Start()
    {
        //异步加载场景
        m_Async = SceneManager.LoadSceneAsync("Chapter07_01", LoadSceneMode.Single);
        m_Async.completed += (async) =>
        {
            Debug.Log($"加载完成:{m_Async.progress}");
        };
    }

    private void Update()
    {
        if (!m_Async.isDone)
        {
            Debug.Log($"加载进度：{m_Async.progress}");
        }
    }
}

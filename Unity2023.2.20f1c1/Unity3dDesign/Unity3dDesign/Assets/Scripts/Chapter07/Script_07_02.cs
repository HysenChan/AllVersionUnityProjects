using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_07_02 : MonoBehaviour
{
    private AsyncOperation m_Async;
    private void Start()
    {
        ////异步加载场景
        //m_Async = SceneManager.LoadSceneAsync("Chapter07_01", LoadSceneMode.Single);
        //m_Async.completed += (async) =>
        //{
        //    Debug.Log($"加载完成:{m_Async.progress}");
        //};
        //避免当前脚本在切换场景时被剔除，通过DontDestroyOnLoad设置
        DontDestroyOnLoad(this);
        SceneMod.LoadScene("Chapter07_01", () =>
        {
            Debug.Log($"场景加载完成");
        });
    }

    //IEnumerator LoadScene(string sceneName, System.Action finish)
    //{
    //    AsyncOperation async = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    //    yield return async;
    //    finish?.Invoke();
    //}

    //private void Update()
    //{
    //    if (!m_Async.isDone)
    //    {
    //        Debug.Log($"加载进度：{m_Async.progress}");
    //    }
    //}
    public class SceneMod
    {
        public static void LoadScene(string name, Action finish)
        {
            //新场景和当前场景一致时，直接返回加载成功事件
            if (SceneManager.GetActiveScene().name == name)
            {
                finish?.Invoke();
                return;
            }
            //加载一个空场景
            SceneManager.LoadScene("Empty");
            //异步加载场景
            var async = SceneManager.LoadSceneAsync(name, LoadSceneMode.Single);
            async.completed += (async) =>
            {
                finish?.Invoke();
            };
        }
    }
}

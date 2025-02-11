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
        ////�첽���س���
        //m_Async = SceneManager.LoadSceneAsync("Chapter07_01", LoadSceneMode.Single);
        //m_Async.completed += (async) =>
        //{
        //    Debug.Log($"�������:{m_Async.progress}");
        //};
        //���⵱ǰ�ű����л�����ʱ���޳���ͨ��DontDestroyOnLoad����
        DontDestroyOnLoad(this);
        SceneMod.LoadScene("Chapter07_01", () =>
        {
            Debug.Log($"�����������");
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
    //        Debug.Log($"���ؽ��ȣ�{m_Async.progress}");
    //    }
    //}
    public class SceneMod
    {
        public static void LoadScene(string name, Action finish)
        {
            //�³����͵�ǰ����һ��ʱ��ֱ�ӷ��ؼ��سɹ��¼�
            if (SceneManager.GetActiveScene().name == name)
            {
                finish?.Invoke();
                return;
            }
            //����һ���ճ���
            SceneManager.LoadScene("Empty");
            //�첽���س���
            var async = SceneManager.LoadSceneAsync(name, LoadSceneMode.Single);
            async.completed += (async) =>
            {
                finish?.Invoke();
            };
        }
    }
}

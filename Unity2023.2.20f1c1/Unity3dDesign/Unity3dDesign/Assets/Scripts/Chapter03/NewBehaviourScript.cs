using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
    static void OnAfterAssembliesLoaded()
    {
        // 这里的代码将在所有程序集加载完成后执行
        Debug.Log("所有程序集已加载，执行初始化逻辑。");
    }

    //private void Awake()
    //{
    //    Debug.Log("Awake " + Time.frameCount);
        //Application.targetFrameRate = 25;
    //}

    //    private void OnEnable()
    //    {
    //        Debug.Log("OnEnable");
    //    }

    //#if UNITY_EDITOR
    //    private void Reset()
    //    {
    //        Debug.Log("Reset");
    //    }
    //#endif

    //    private void Start()
    //    {
    //        Debug.Log("Start " + Time.frameCount);
    //    }

    //    private void OnApplicationQuit()
    //    {
    //        Debug.Log("OnApplicationQuit");
    //    }

    //    private void OnDisable()
    //    {
    //        Debug.Log("OnDisable");
    //    }

    //    private void OnDestroy()
    //    {
    //        Debug.Log("OnDestroy");
    //    }

    //private void FixedUpdate()
    //{
    //    Debug.Log($"frameCount={Time.frameCount} time={Time.time}");
    //}

    //private void Update()
    //{
    //    Debug.Log($"Update time={Time.time}");
    //}
}

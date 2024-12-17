using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements.Experimental;

public class Script_03_09 : MonoBehaviour
{
    //private void Start()
    //{
    //    Coroutine coroutine = WaitTimeManager.WaitTime(5, () =>
    //    {
    //        Debug.Log("5秒等待结束");
    //    });

    //    //等待结束前是否关闭
    //    //WaitTimeManager.CancelWait(ref coroutine);
    //}

    //public class WaitTimeManager
    //{
    //    private static TaskBehaviour s_Task;
    //    static WaitTimeManager()
    //    {
    //        //创建一个临时对象，绑定内部类专门用于处理协程任务
    //        GameObject go = new GameObject("#WaitTimeManager#");
    //        GameObject.DontDestroyOnLoad(go);
    //        s_Task = go.AddComponent<TaskBehaviour>();
    //    }

    //    //开始等待
    //    static public Coroutine WaitTime(float time, UnityAction callback)
    //    {
    //        return s_Task.StartCoroutine(Coroutine(time, callback));
    //    }
    //    //取消等待
    //    static public void CancelWait(ref Coroutine coroutine)
    //    {
    //        if (coroutine != null)
    //        {
    //            s_Task.StopCoroutine(coroutine);
    //            coroutine = null;
    //        }
    //    }

    //    static IEnumerator Coroutine(float time, UnityAction callback)
    //    {
    //        yield return new WaitForSeconds(time);
    //        callback?.Invoke();
    //    }
    //    //内部类
    //    class TaskBehaviour : MonoBehaviour { }
    //}

    async void InternalDelay(int time, CancellationToken token, Action finish)
    {
        try
        {
            await Task.Delay(time, token);//开启线程，此时主线程并非卡住
            finish?.Invoke();//定时结束后返回主线程，抛出结束事件
        }
        catch (TaskCanceledException)
        {
        }
    }

    private void Start()
    {
        var source = Delay(1000, () =>
        {
            Debug.Log("1秒后回调");
        });

        //1秒回调之前可以提前结束它
        //source.Cancel();
    }

    CancellationTokenSource Delay(int time, Action finish)
    {
        CancellationTokenSource source = new CancellationTokenSource();
        InternalDelay(time, source.Token, finish);
        return source;
    }
}
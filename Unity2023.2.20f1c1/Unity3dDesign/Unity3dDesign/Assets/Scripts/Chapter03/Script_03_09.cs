using System.Collections;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements.Experimental;

public class Script_03_09 : MonoBehaviour
{
    private void Start()
    {
        Coroutine coroutine = WaitTimeManager.WaitTime(5, () =>
        {
            Debug.Log("5秒等待结束");
        });

        //等待结束前是否关闭
        //WaitTimeManager.CancelWait(ref coroutine);
    }

    public class WaitTimeManager
    {
        private static TaskBehaviour s_Task;
        static WaitTimeManager()
        {
            //创建一个临时对象，绑定内部类专门用于处理协程任务
            GameObject go = new GameObject("#WaitTimeManager#");
            GameObject.DontDestroyOnLoad(go);
            s_Task = go.AddComponent<TaskBehaviour>();
        }

        //开始等待
        static public Coroutine WaitTime(float time, UnityAction callback)
        {
            return s_Task.StartCoroutine(Coroutine(time, callback));
        }
        //取消等待
        static public void CancelWait(ref Coroutine coroutine)
        {
            if (coroutine != null)
            {
                s_Task.StopCoroutine(coroutine);
                coroutine = null;
            }
        }

        static IEnumerator Coroutine(float time, UnityAction callback)
        {
            yield return new WaitForSeconds(time);
            callback?.Invoke();
        }
        //内部类
        class TaskBehaviour : MonoBehaviour { }
    }
}
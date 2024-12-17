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
            Debug.Log("5��ȴ�����");
        });

        //�ȴ�����ǰ�Ƿ�ر�
        //WaitTimeManager.CancelWait(ref coroutine);
    }

    public class WaitTimeManager
    {
        private static TaskBehaviour s_Task;
        static WaitTimeManager()
        {
            //����һ����ʱ���󣬰��ڲ���ר�����ڴ���Э������
            GameObject go = new GameObject("#WaitTimeManager#");
            GameObject.DontDestroyOnLoad(go);
            s_Task = go.AddComponent<TaskBehaviour>();
        }

        //��ʼ�ȴ�
        static public Coroutine WaitTime(float time, UnityAction callback)
        {
            return s_Task.StartCoroutine(Coroutine(time, callback));
        }
        //ȡ���ȴ�
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
        //�ڲ���
        class TaskBehaviour : MonoBehaviour { }
    }
}
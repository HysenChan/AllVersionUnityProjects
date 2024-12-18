using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class Script_03_10 : MonoBehaviour
{
    //IEnumerator Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        //10�����
    //        yield return new CustomWait(10f, 1f, () =>
    //        {
    //            Debug.LogFormat($"ÿ��1��ص�һ��:{Time.time}");
    //        });
    //        Debug.Log("10�����");
    //    }
    //}
    //public class CustomWait : CustomYieldInstruction
    //{
    //    public override bool keepWaiting
    //    {
    //        get
    //        {
    //            //�˷�������false��ʾЭ�̽���
    //            if (Time.time - m_StartTime >= m_Time)
    //            {
    //                return false;
    //            }
    //            else if (Time.time - m_LastTime >= m_Interval)
    //            {
    //                //������һ�μ��ʱ��
    //                m_LastTime = Time.time;
    //                m_IntervalCallback?.Invoke();
    //            }
    //            return true;
    //        }
    //    }
    //    private UnityAction m_IntervalCallback;
    //    private float m_StartTime;
    //    private float m_LastTime;
    //    private float m_Interval;
    //    private float m_Time;

    //    public CustomWait(float time, float interval, UnityAction callback)
    //    {
    //        //��¼��ʼʱ��
    //        m_StartTime = Time.time;
    //        //��¼��һ�μ��ʱ��
    //        m_LastTime = Time.time;
    //        //��¼�������ʱ��
    //        m_Interval = interval;
    //        //��¼��ʱ��
    //        m_Time = time;
    //        //����ص�
    //        m_IntervalCallback = callback;
    //    }
    //}

    ///Awaitable
    ///

    private async Awaitable Start()
    {
        ////��1֡
        //await Awaitable.NextFrameAsync();
        ////��1��
        //await Awaitable.WaitForSecondsAsync(1f);
        ////����һ֡FixedUpdate֮��
        //await Awaitable.FixedUpdateAsync();
        ////�ȵ���ǰ֡���
        //await Awaitable.EndOfFrameAsync();

        //�ȴ���Դ�������
        var r = Resources.LoadAsync<Material>("name");
        await r;
        Material material = (Material)r.asset;

        //�ȴ������������
        await SceneManager.LoadSceneAsync("SomeScene");
        //�ȴ�Assetbundle�������
        var a = AssetBundle.LoadFromFileAsync("path");
        await a;

        //�ȴ�Asset�ļ��������
        AssetBundle ab = a.assetBundle;
        await ab.LoadAssetAsync("name");
    }

}
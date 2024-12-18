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
    //        //10秒结束
    //        yield return new CustomWait(10f, 1f, () =>
    //        {
    //            Debug.LogFormat($"每过1秒回调一次:{Time.time}");
    //        });
    //        Debug.Log("10秒结束");
    //    }
    //}
    //public class CustomWait : CustomYieldInstruction
    //{
    //    public override bool keepWaiting
    //    {
    //        get
    //        {
    //            //此方法返回false表示协程结束
    //            if (Time.time - m_StartTime >= m_Time)
    //            {
    //                return false;
    //            }
    //            else if (Time.time - m_LastTime >= m_Interval)
    //            {
    //                //更新上一次间隔时间
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
    //        //记录开始时间
    //        m_StartTime = Time.time;
    //        //记录上一次间隔时间
    //        m_LastTime = Time.time;
    //        //记录间隔调用时间
    //        m_Interval = interval;
    //        //记录总时间
    //        m_Time = time;
    //        //间隔回调
    //        m_IntervalCallback = callback;
    //    }
    //}

    ///Awaitable
    ///

    private async Awaitable Start()
    {
        ////等1帧
        //await Awaitable.NextFrameAsync();
        ////等1秒
        //await Awaitable.WaitForSecondsAsync(1f);
        ////等下一帧FixedUpdate之后
        //await Awaitable.FixedUpdateAsync();
        ////等到当前帧最后
        //await Awaitable.EndOfFrameAsync();

        //等待资源加载完毕
        var r = Resources.LoadAsync<Material>("name");
        await r;
        Material material = (Material)r.asset;

        //等待场景加载完毕
        await SceneManager.LoadSceneAsync("SomeScene");
        //等待Assetbundle加载完毕
        var a = AssetBundle.LoadFromFileAsync("path");
        await a;

        //等待Asset文件加载完毕
        AssetBundle ab = a.assetBundle;
        await ab.LoadAssetAsync("name");
    }

}
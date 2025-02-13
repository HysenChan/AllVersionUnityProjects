using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_07 : MonoBehaviour
{
    private PlayableGraph m_PlayableGraph;

    private void Start()
    {
        m_PlayableGraph = PlayableGraph.Create();
        //创建自定义Playable组件
        var customPlayable = ScriptPlayable<CustomplayableBehaviour>.Create(m_PlayableGraph);
        //创建自定义Output组件
        var customOutput = ScriptPlayableOutput.Create(m_PlayableGraph, "customOutput");
        //关联
        customOutput.SetSourcePlayable(customPlayable);
        //播放
        m_PlayableGraph.Play();
    }

    public class CustomplayableBehaviour : PlayableBehaviour
    {
        public override void OnGraphStart(Playable playable)
        {
            UnityEngine.Debug.Log("PlayableGraph开始时触发");
        }
        public override void OnGraphStop(Playable playable)
        {
            UnityEngine.Debug.Log("PlayableGraph结束时触发");
        }
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            UnityEngine.Debug.Log("脚本开始时触发");
        }
        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            UnityEngine.Debug.Log("脚本暂停时触发");
        }
        public override void PrepareFrame(Playable playable, FrameData info)
        {
            //每一帧循环触发
        }
    }

    private void OnDisable()
    {
        m_PlayableGraph.Destroy();
    }
}

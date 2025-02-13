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
        //�����Զ���Playable���
        var customPlayable = ScriptPlayable<CustomplayableBehaviour>.Create(m_PlayableGraph);
        //�����Զ���Output���
        var customOutput = ScriptPlayableOutput.Create(m_PlayableGraph, "customOutput");
        //����
        customOutput.SetSourcePlayable(customPlayable);
        //����
        m_PlayableGraph.Play();
    }

    public class CustomplayableBehaviour : PlayableBehaviour
    {
        public override void OnGraphStart(Playable playable)
        {
            UnityEngine.Debug.Log("PlayableGraph��ʼʱ����");
        }
        public override void OnGraphStop(Playable playable)
        {
            UnityEngine.Debug.Log("PlayableGraph����ʱ����");
        }
        public override void OnBehaviourPlay(Playable playable, FrameData info)
        {
            UnityEngine.Debug.Log("�ű���ʼʱ����");
        }
        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            UnityEngine.Debug.Log("�ű���ͣʱ����");
        }
        public override void PrepareFrame(Playable playable, FrameData info)
        {
            //ÿһ֡ѭ������
        }
    }

    private void OnDisable()
    {
        m_PlayableGraph.Destroy();
    }
}

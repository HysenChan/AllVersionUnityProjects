using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_04 : MonoBehaviour
{
    public Slider slider;
    public AnimationClip Run;
    public AnimationClip Idle;

    private Animator m_Animator;
    private PlayableGraph m_PlayableGraph;
    private AnimationMixerPlayable m_AnimationMixerPlayable;
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
        //创建Playable
        m_PlayableGraph = PlayableGraph.Create();
        var playableOutput = AnimationPlayableOutput.Create(m_PlayableGraph, "MyName", m_Animator);

        //准备需要混合的动画
        List<AnimationClipPlayable> list = new List<AnimationClipPlayable>()
        {
            AnimationClipPlayable.Create(m_PlayableGraph, Run),
            AnimationClipPlayable.Create(m_PlayableGraph, Idle)
        };
        //创建混合Playable
        m_AnimationMixerPlayable = AnimationMixerPlayable.Create(m_PlayableGraph, list.Count);
        playableOutput.SetSourcePlayable(m_AnimationMixerPlayable);
        //将所有混合的Playable关联到主Playable中
        for (int i = 0; i < list.Count; i++)
        {
            m_PlayableGraph.Connect(list[i], 0, m_AnimationMixerPlayable, i);
        }
        m_PlayableGraph.Play();
    }

    private void Update()
    {
        //通过权重来决定播放比例
        float weight = Mathf.Clamp01(slider.value);
        m_AnimationMixerPlayable.SetInputWeight(0, 1.0f - weight);
        m_AnimationMixerPlayable.SetInputWeight(1, weight);
    }

    private void OnDestroy()
    {
        m_PlayableGraph.Destroy();
    }
}

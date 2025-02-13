using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Script_07_06 : MonoBehaviour
{
    //��Ƶ
    public AudioClip clip1;
    public AudioClip clip2;
    //Ȩ��
    public float weight;
    PlayableGraph m_PlayableGraph;
    AudioMixerPlayable m_AudioMixerPlayable;

    private void Start()
    {
        m_PlayableGraph = PlayableGraph.Create();
        m_AudioMixerPlayable = AudioMixerPlayable.Create(m_PlayableGraph, 2);
        //������Ƶ��PlayableGraph
        var audioClipPlayable1 = AudioClipPlayable.Create(m_PlayableGraph, clip1, true);
        var audioClipPlayable2 = AudioClipPlayable.Create(m_PlayableGraph, clip2, true);
        m_PlayableGraph.Connect(audioClipPlayable1, 0, m_AudioMixerPlayable, 0);
        m_PlayableGraph.Connect(audioClipPlayable2, 0, m_AudioMixerPlayable, 1);

        //�����Ƶ���
        var audioPlayableOutput = AudioPlayableOutput.Create(m_PlayableGraph, "Audio", GetComponent<AudioSource>());
        audioPlayableOutput.SetSourcePlayable(m_AudioMixerPlayable);

        m_PlayableGraph.Play();
    }

    private void Update()
    {
        //���û��Ȩ�أ�������0��1֮��
        weight = Mathf.Clamp01(weight);
        m_AudioMixerPlayable.SetInputWeight(0, 1.0f - weight);
        m_AudioMixerPlayable.SetInputWeight(1, weight);
    }

    private void OnDisable()
    {
        //����PlayableGraph
        m_PlayableGraph.Destroy();
    }
}

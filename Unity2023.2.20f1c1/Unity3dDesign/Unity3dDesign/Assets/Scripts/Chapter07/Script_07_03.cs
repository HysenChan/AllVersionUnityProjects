using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Script_07_03 : MonoBehaviour
{
    //提前序列化所有动画
    public List<AnimationClip> AnimationClips = new List<AnimationClip>();
    private Animator m_Animator;
    private PlayableGraph m_PlayableGraph;
    private Dictionary<string, AnimationClip> m_Dict = new Dictionary<string, AnimationClip>();
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
        //将动画保存在字典中
        foreach (var clip in AnimationClips)
        {
            m_Dict[clip.name] = clip;
        }

        //播放动画等回调
        StartCoroutine(Play("Attack", () =>
        {
            Debug.Log("动画播放完毕");
        }));
    }

    IEnumerator Play(string name, Action finish)
    {
        var clip = m_Dict[name];
        //使用Playable播放动画
        AnimationPlayableUtilities.PlayClip(m_Animator, clip, out m_PlayableGraph);
        //等待播放的动画时长后返回
        yield return new WaitForSeconds(clip.length);
        finish?.Invoke();
    }

    private void OnDestroy()
    {
        m_PlayableGraph.Destroy();
    }
}

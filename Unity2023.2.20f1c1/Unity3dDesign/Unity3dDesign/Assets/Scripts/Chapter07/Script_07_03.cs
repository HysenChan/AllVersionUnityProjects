using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Script_07_03 : MonoBehaviour
{
    //��ǰ���л����ж���
    public List<AnimationClip> AnimationClips = new List<AnimationClip>();
    private Animator m_Animator;
    private PlayableGraph m_PlayableGraph;
    private Dictionary<string, AnimationClip> m_Dict = new Dictionary<string, AnimationClip>();
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
        //�������������ֵ���
        foreach (var clip in AnimationClips)
        {
            m_Dict[clip.name] = clip;
        }

        //���Ŷ����Ȼص�
        StartCoroutine(Play("Attack", () =>
        {
            Debug.Log("�����������");
        }));
    }

    void Play(string name)
    {
        var clip = m_Dict[name];
        //ʹ��Playable���Ŷ���
        AnimationPlayableUtilities.PlayClip(m_Animator, clip, out m_PlayableGraph);
    }

    IEnumerator Play(string name, Action finish)
    {
        Play(name);
        //�ȴ����ŵĶ���ʱ���󷵻�
        yield return new WaitForSeconds(m_Dict[name].length);
        finish?.Invoke();
    }

    private void OnDestroy()
    {
        m_PlayableGraph.Destroy();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(Play("Attack", () =>
            {
                Play("Idle");
            }));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(Play("Die", () =>
            {
                Play("Idle");
            }));
        }

    }
}

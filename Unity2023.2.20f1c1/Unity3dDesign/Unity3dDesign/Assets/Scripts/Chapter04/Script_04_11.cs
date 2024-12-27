using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_11 : MonoBehaviour
{
    //private void Start()
    //{
    //    SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>("Chapter04/SpriteAtlas");

    //    //��ͼ���л�ȡ����Ϊunityicon��Sprite
    //    Sprite sprite = spriteAtlas.GetSprite("unityicon");
    //    GetComponent<Image>().sprite = sprite;

    //    //��ȡͼ���е�����Sprite��������������
    //    Sprite[] sprites = new Sprite[spriteAtlas.spriteCount];
    //    spriteAtlas.GetSprites(sprites);
    //}

    private void OnEnable()
    {
        SpriteAtlasManager.atlasRequested += AtlasRequested;
        SpriteAtlasManager.atlasRegistered += AtlasRegistered;
    }

    private void OnDisable()
    {
        SpriteAtlasManager.atlasRequested -= AtlasRequested;
        SpriteAtlasManager.atlasRegistered += AtlasRegistered;
    }

    void AtlasRequested(string atlas, Action<SpriteAtlas> action)
    {
        Debug.Log($"{atlas}��ʼ����");
        //ͨ��Action�����غ��ͼ������ص���ȥ
        action(Resources.Load<SpriteAtlas>($"Chapter04/Atlas/{atlas}"));
    }

    void AtlasRegistered(SpriteAtlas atlas)
    {
        Debug.Log($"{atlas}�������");
    }
}

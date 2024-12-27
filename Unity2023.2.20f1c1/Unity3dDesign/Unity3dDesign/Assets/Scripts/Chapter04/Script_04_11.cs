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

    //    //从图集中获取名称为unityicon的Sprite
    //    Sprite sprite = spriteAtlas.GetSprite("unityicon");
    //    GetComponent<Image>().sprite = sprite;

    //    //获取图集中的所有Sprite并保存在数组中
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
        Debug.Log($"{atlas}开始加载");
        //通过Action将加载后的图集对象回调出去
        action(Resources.Load<SpriteAtlas>($"Chapter04/Atlas/{atlas}"));
    }

    void AtlasRegistered(SpriteAtlas atlas)
    {
        Debug.Log($"{atlas}加载完成");
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Script_04_11 : MonoBehaviour
{
    private void Start()
    {
        SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>("Chapter04/SpriteAtlas");

        //��ͼ���л�ȡ����Ϊunityicon��Sprite
        Sprite sprite = spriteAtlas.GetSprite("unityicon");
        GetComponent<Image>().sprite = sprite;

        //��ȡͼ���е�����Sprite��������������
        Sprite[] sprites = new Sprite[spriteAtlas.spriteCount];
        spriteAtlas.GetSprites(sprites);
    }
}

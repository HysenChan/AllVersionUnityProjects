using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_10 : MonoBehaviour
{
    public SpriteMask spriteMask;
    private void Awake()
    {
        spriteMask.sprite = Sprite.Create(Texture2D.whiteTexture, new Rect(0.0f, 0.0f, 1, 1), Vector2.one * 0.5f);
        RectTransform rectTransform = (transform as RectTransform);
        spriteMask.transform.localScale = rectTransform.rect.size * 100f;
    }
}

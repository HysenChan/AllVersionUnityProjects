using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_04_02 : MonoBehaviour, IPointerClickHandler
{
    TextMeshProUGUI m_TextMeshProUGUI;
    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        //如果UI是用单独的摄像机看的，需要将摄像机传入第三个参数
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(m_TextMeshProUGUI, eventData.position, null);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = m_TextMeshProUGUI.textInfo.linkInfo[linkIndex];
            //输出点击的link标签名称
            Debug.Log($"LinkID:{linkInfo.GetLinkID()}");
        }
    }
}

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
        //���UI���õ�������������ģ���Ҫ��������������������
        int linkIndex = TMP_TextUtilities.FindIntersectingLink(m_TextMeshProUGUI, eventData.position, null);
        if (linkIndex != -1)
        {
            TMP_LinkInfo linkInfo = m_TextMeshProUGUI.textInfo.linkInfo[linkIndex];
            //��������link��ǩ����
            Debug.Log($"LinkID:{linkInfo.GetLinkID()}");
        }
    }
}

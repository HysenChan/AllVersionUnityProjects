using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class Script_07_13 : MonoBehaviour
{
    public Image Image;
    public Canvas Canvas;

    private void Update()
    {
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(Canvas.transform as RectTransform, Input.mousePosition, Canvas.worldCamera, out var point))
        {
            Image.transform.position = point;
        }
    }
}

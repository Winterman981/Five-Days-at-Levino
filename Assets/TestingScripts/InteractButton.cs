using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractButton : MonoBehaviour
{
    public Button button;
    public Vector3 offset;
    public RectTransform hpRect;

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.parent.position + offset);

        hpRect.anchorMin = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
        hpRect.anchorMax = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private void Awake()
    {
        Rect rect = Camera.main.rect;

        float height = ((float)Screen.width / Screen.height) / ((float) 16 / 9);
        float width = 1f / height;

        if(height < 1)
        {
            rect.height = height;
            rect.y = (1f - height) / 2f;
        }
        else
        {
            rect.width = width;
            rect.x = (1f - width) / 2f;
        }
        Camera.main.rect = rect;
    }
}

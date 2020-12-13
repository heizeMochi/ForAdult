using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    [SerializeField]
    Sprite spr;
    Image img;

    void Start()
    {
        img = GetComponent<Image>();

        if(Managers.Game.Present != Define.Present.NONE)
        {
            img.sprite = spr;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentImage : MonoBehaviour
{
    SpriteRenderer renderer;
    [SerializeField]
    Sprite guitar, beg, suit;
    public static Define.Present present = Define.Present.NONE;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

        present = Managers.Game.Present;

        switch (present)
        {
            case Define.Present.Beg:
                renderer.sprite = beg;
                break;
            case Define.Present.Guitar:
                renderer.sprite = guitar;
                break;
            case Define.Present.Suit:
                renderer.sprite = suit;
                break;
        }
    }
}

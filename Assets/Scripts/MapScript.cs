using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Managers.Game.Present == Define.Present.NONE)
                return;
            Managers.Game.Present = Define.Present.NONE;
            Debug.Log("이미지변경");
        }
    }
}
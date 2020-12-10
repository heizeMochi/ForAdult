using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investigate : MonoBehaviour
{
    [SerializeField]
    GameObject[] presentScene;
    [SerializeField]
    GameObject[] investigateScene;

    void Awake()
    {
        if(Managers.Game.Present == Define.Present.NONE)
        {
            for (int i = 0; i < presentScene.Length; i++)
            {
                presentScene[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < investigateScene.Length; i++)
            {
                investigateScene[i].SetActive(false);
            }
        }
    }
}

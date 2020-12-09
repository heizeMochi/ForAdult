using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeOut : MonoBehaviour
{
    [SerializeField]
    GameObject[] gos;

    void Start()
    {
        gos[0] = transform.GetChild(0).gameObject;
        gos[1] = transform.GetChild(1).gameObject;
        gos[2] = transform.GetChild(2).gameObject;

        for (int i = 0; i < Managers.Game.presents.Count; i++)
        {
            gos[i].SetActive(true);
            SelectPresent sp = gos[i].GetComponent<SelectPresent>();
            sp.present = Managers.Game.presents[i];
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public List<Define.Present> presents = new List<Define.Present>();
    public int actionCount = 3;
    public int findAction = 0;

    public void Init()
    {
        actionCount = 3;
        findAction = 0;
    }

    public void FindPresent(Define.Present present)
    {
        if (presents.Contains(present))
            return;
        presents.Add(present);
        findAction++;
        for (int i = 0; i < presents.Count; i++)
        {
            Debug.Log(presents[i]);
        }
    }
}
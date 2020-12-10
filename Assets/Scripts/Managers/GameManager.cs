using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public Define.Present Present = Define.Present.NONE;
    public string NPCName = "";

    public List<Define.Present> presents = new List<Define.Present>();
    public int actionCount = 3;
    public int findAction = 0;

    public void Init()
    {
        actionCount = 3;
        findAction = 0;
    }

    public void FindPresent(Define.Present present, string name)
    {
        if (presents.Contains(present))
            return;
        NPCName = name;
        presents.Add(present);
        findAction++;

        for (int i = 0; i < presents.Count; i++)
        {
            Debug.Log(presents[i]);
        }
    }
}
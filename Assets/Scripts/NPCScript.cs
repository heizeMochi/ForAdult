using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public string npcName;
    public GameObject[] PresentList;
    public List<string> chats = new List<string>();
    public string chat;
    [SerializeField]
    GameObject scenechange;

    private void Start()
    {
        if (Managers.Game.Present != Define.Present.NONE)
            gameObject.SetActive(false);
    }

    public void BegInstantiate()
    {
        for (int i = 0; i < PresentList.Length; i++)
        {
            if (PresentList[i].gameObject.name == "Beg")
                PresentList[i].SetActive(true);
        }
    }
}
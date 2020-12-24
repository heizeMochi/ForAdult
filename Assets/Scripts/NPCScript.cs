using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public string npcName;
    public GameObject[] PresentList;
    public List<string> chats;
    public List<string> names;
    public string chat;
    public TextBoard board;
    [SerializeField]
    GameObject scenechange;

    private void Start()
    {
        if (Managers.Game.Present != Define.Present.NONE)
            gameObject.SetActive(false);
    }

    public void TalkNPC1()
    {
        if(Managers.Game.chat)
        {
            Invoke("TalkNPC1", 1f);
            return;
        }
        board.names = names;
        board.contexts = chats;
        board.gameObject.SetActive(true);
        board.Init();
    }

    public void BegInstantiate()
    {
        for (int i = 0; i < PresentList.Length; i++)
        {
            if (PresentList[i].gameObject.name == "Beg")
                PresentList[i].SetActive(true);
        }
    }

    public void SuitInstantiate()
    {
        for (int i = 0; i < PresentList.Length; i++)
        {
            if (PresentList[i].gameObject.name == "Suit")
                PresentList[i].SetActive(true);
        }
    }
}
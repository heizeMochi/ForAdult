using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCTalk : MonoBehaviour
{
    Button btn;

    GameObject background;
    Text name, context;

    public void Init()
    {
        if (GameObject.Find("Canvas").transform.Find("TextBackground") == null)
            return;

        background = GameObject.Find("Canvas").transform.Find("TextBackground").gameObject;
        TalkManager tm = background.AddComponent<TalkManager>();
        Managers.Instance.TalkInit(tm);
        name = background.transform.Find("NameText").GetComponent<Text>();
        context = background.transform.Find("Text").GetComponent<Text>();
        btn = background.transform.Find("NextBtn").GetComponent<Button>();
    }
}

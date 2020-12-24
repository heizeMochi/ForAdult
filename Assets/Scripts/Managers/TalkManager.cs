using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkManager : MonoBehaviour
{
    bool talk = false;

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

    public void Talk(string _name, string _context)
    {
        if (Managers.Game.chat)
            return;
        Managers.Game.chat = true;
        if (background == null)
            Init();
        background.SetActive(true);
        StartCoroutine(TalkCoroutine(_name, _context));
    }

    public void Talk(string _name, List<string> _context)
    {
        if (Managers.Game.chat)
            return;
        Managers.Game.chat = true;
        if (background == null)
            Init();
        background.SetActive(true);
        StartCoroutine(TalkIndex(_name, _context));
    }

    public void Talk(List<string> _name, List<string> _context)
    {
        if (Managers.Game.chat)
            return;
        Managers.Game.chat = true;
        if (background == null)
            Init();
        background.SetActive(true);
        StartCoroutine(TalkIndex(_name, _context));
    }

    IEnumerator TalkIndex(string _name, List<string> _context)
    {

        for (int i = 0; i < _context.Count; i++)
        {
            StartCoroutine(TalkCoroutine(_name, _context[i]));
            yield return new WaitForSeconds(0.2f * _context.Count);
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        }
    }

    IEnumerator TalkIndex(List<string> _name, List<string> _context)
    {

        for (int i = 0; i < _name.Count; i++)
        {
            StartCoroutine(TalkCoroutine(_name[i], _context[i]));
            yield return new WaitForSeconds(0.2f * _context.Count);
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        }
        CloseText();
    }

    IEnumerator TalkCoroutine(string _name, string _context)
    {
        name.text = _name;
        context.text = "";

        char[] ch = _context.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            context.text += ch[i];
            yield return new WaitForSeconds(0.1f);
        }
        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(CloseText);
        yield return null;
    }

    public void CloseText()
    {
        Managers.Game.chat = false;
        background.SetActive(false);
    }
}
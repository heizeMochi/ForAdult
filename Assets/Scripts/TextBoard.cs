using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoard : MonoBehaviour
{
    public Text nameText;
    public Text contextText;
    public Button btn;
    public List<string> names;
    public List<string> contexts;
    public static int count = 0;

    bool check = true;

    public GameObject panel;

    public void Init()
    {
        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(NextText);
        nameText.text = "";
        contextText.text = "";
        count = names.Count;

        TextOutput();
    }

    public void TextOutput()
    {
        Managers.Game.chat = true;
        check = false;
        StartCoroutine(Talk(names[0], contexts[0]));
    }

    public void NextText()
    {
        if (!check)
            return;

        panel.SetActive(false);
        Managers.Game.chat = false;
        nameText.text = "";
        contextText.text = "";
        if (count != 0)
        {
            names.RemoveAt(0);
            contexts.RemoveAt(0);
            count--;
        }
        if (contexts.Count == 0)
        {
            CloseText();
            Animator anim = GameObject.Find("NPC").GetComponent<Animator>();
            anim.SetBool("TalkOff", true);
            return;
        }
        TextOutput();
    }

    void CloseText()
    {
        gameObject.SetActive(false);
    }

    IEnumerator Talk(string name, string context)
    {
        nameText.text = name;

        char[] ch = context.ToCharArray();

        for (int i = 0; i < ch.Length; i++)
        {
            if(ch[i] == '기')
            {
                panel.SetActive(true);
            }else if(ch[i] == '타')
            {
                panel.transform.Find("Text").GetComponent<Text>().text += '타';
            }
            contextText.text += ch[i];
            yield return new WaitForSeconds(0.1f);
        }
        check = true;
    }
}

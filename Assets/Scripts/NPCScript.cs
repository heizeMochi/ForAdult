using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public string npcName;
    public Define.Present[] presents;
    public List<bool> b_presents = new List<bool>();
    public List<string> chats = new List<string>();
    public string chat;
    [SerializeField]
    GameObject scenechange;

    private void Start()
    {
        for (int i = 0; i < presents.Length; i++)
        {
            b_presents.Add(new bool());
        }
    }

    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 0f);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider == null)
                return;
            if (hit.collider.gameObject == gameObject)
            {
                for (int i = 0; i < b_presents.Count; i++)
                {
                    if (b_presents[i])
                    {
                        b_presents[i] = false;
                        Managers.Game.FindPresent(presents[i], npcName);
                        scenechange.SetActive(true);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            Animator anim = GetComponent<Animator>();
            anim.SetTrigger("Beg");
        }

    }

    public void BegTrue()
    {
        for (int i = 0; i < presents.Length; i++)
        {
            if (presents[i] == Define.Present.Beg)
            {
                b_presents[i] = true;
            }
        }
    }

    public void BegFalse()
    {
        for (int i = 0; i < presents.Length; i++)
        {
            if (presents[i] == Define.Present.Beg)
            {
                b_presents[i] = false;
            }
        }
    }
}
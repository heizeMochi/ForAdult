using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject In, Out;
    public bool cling = false;
    public Rigidbody2D rigid;
    bool goal = false;
    Animator anim;
    [SerializeField]
    GameObject present;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (cling)
        {
            In.SetActive(false);
            Out.SetActive(true);
        }else if (!cling)
        {
            In.SetActive(true);
            Out.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            if(!goal)
            {

                collision.gameObject.SetActive(false);
                goal = true;
                Collider2D col = GameObject.Find("Goal2").GetComponent<Collider2D>();
                col.enabled = true;
                anim.SetBool("Over", true);
                present.transform.SetParent(transform);
                present.transform.localPosition = new Vector3(0f, 0.85f, 0);
            }
            else
            {
                Fade fade = GameObject.FindObjectOfType<Fade>(true);
                fade.SceneName = "Clear";
                fade.gameObject.SetActive(true);
            }
        }
        if (collision.gameObject == In)
        {
            cling = true;
            rigid.gravityScale = 0;
        }
        else if (collision.gameObject == Out)
        {
            cling = false;
            rigid.gravityScale = 4f;
        }
        else
            rigid.gravityScale = 8f;
    }
}

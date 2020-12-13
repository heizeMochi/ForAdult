using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    GameObject In, Out;
    public bool cling = false;
    public Rigidbody2D rigid;

    private void Start()
    {
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

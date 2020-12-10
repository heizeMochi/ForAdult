using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool cling = false;
    public Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            Debug.Log("들어옴");
            cling = true;
            rigid.velocity = Vector2.zero;
            rigid.gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            Debug.Log("나감");
            cling = false;
            rigid.gravityScale = 8;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        cling = false;
    }
}

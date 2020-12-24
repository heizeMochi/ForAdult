using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    Player player;
    Animator anim;
    public float speed;

    bool rightMove;
    bool leftMove;

    private void Start()
    {
        if (!player.gameObject.activeSelf)
            player.gameObject.SetActive(true);
        anim = player.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (rightMove)
            RightMove();
        else if (leftMove)
            LeftMove();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        anim.SetBool("Walking", true);
        if (gameObject.name.Contains("LeftMove"))
            leftMove = true;
        else if (gameObject.name.Contains("RightMove"))
            rightMove = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        StopMove();
    }

    void RightMove()
    {
        player.transform.localScale = new Vector3(1, 1, 1);
        if (player.cling)
        {
            player.rigid.velocity = Vector2.down * speed * Time.deltaTime;
        }
        else
        {
            Vector2 dir = Vector2.right * speed *Time.deltaTime;
            dir.y = player.rigid.velocity.y;
            player.rigid.velocity = dir;
        }
    }

    void LeftMove()
    {
        player.transform.localScale = new Vector3(-1, 1, 1);
        if (player.cling)
        {
            player.rigid.velocity = Vector2.up * speed * Time.deltaTime;
        }
        else
            player.rigid.velocity = Vector2.left * speed * Time.deltaTime;
    }

    void StopMove()
    {
        anim.SetBool("Walking", false);
        rightMove = false;
        leftMove = false;
        player.rigid.velocity = Vector2.zero;
    }
}

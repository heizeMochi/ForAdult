using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentClick : MonoBehaviour
{
    public string chat;
    public GameObject GoTakeOut;

    private void Update()
    {
        InputFunc();
    }

    void InputFunc()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.forward, 10f);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit == false)
                return;
            if (hit.collider.gameObject == gameObject)
            {
                Managers.Game.FindPresent((Define.Present)Enum.Parse(typeof(Define.Present), gameObject.name), gameObject.name);
                Managers.Talk.Talk(gameObject.name, chat);
                GoTakeOut.SetActive(true);
            }
        }
    }
}

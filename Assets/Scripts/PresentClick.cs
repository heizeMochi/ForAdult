using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentClick : MonoBehaviour
{
    public GameObject GoTakeOut;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.forward, 10f);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider.gameObject == gameObject)
            {
                Managers.Game.FindPresent((Define.Present)Enum.Parse(typeof(Define.Present), gameObject.name), gameObject.name);
                GoTakeOut.SetActive(true);
            }
        }
    }
}

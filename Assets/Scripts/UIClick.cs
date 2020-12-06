using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClick : MonoBehaviour,IPointerClickHandler
{
    static GameObject btn;
    [SerializeField]
    bool present;
    [SerializeField]
    GameObject textObj;

    Image img;

    private void Start()
    {
        btn = GameObject.Find("Canvas").transform.Find("Present").gameObject;
        img = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!present)
            return;
        Managers.Game.FindPresent((Define.Present)Enum.Parse(typeof(Define.Present), gameObject.name));
        if(!btn.activeSelf)
        {
            btn.SetActive(true);
            textObj.SetActive(true);
        }
    }
}

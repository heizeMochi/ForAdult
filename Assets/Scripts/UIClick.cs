using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    static GameObject btn;

    Image img;
    [SerializeField]
    Sprite enterImg;

    Sprite defaultImg;

    private void Start()
    {
        btn = GameObject.Find("Canvas").transform.Find("Present").gameObject;
        img = GetComponent<Image>();
        defaultImg = img.sprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Managers.Game.findAction++;
        if(!btn.activeSelf)
        {
            btn.SetActive(true);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        img.sprite = enterImg;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        img.sprite = defaultImg;
    }
}

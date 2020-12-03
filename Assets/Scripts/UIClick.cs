using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClick : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    Image img;
    [SerializeField]
    Sprite enterImg;

    Sprite defaultImg;

    private void Start()
    {
        img = GetComponent<Image>();
        defaultImg = img.sprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
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

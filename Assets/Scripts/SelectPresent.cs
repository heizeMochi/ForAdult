using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectPresent : MonoBehaviour, IPointerClickHandler
{
    public Define.Present present = Define.Present.NONE;
    [SerializeField]
    SelectedPresent selectUI;

    public void OnPointerClick(PointerEventData eventData)
    {
        selectUI.gameObject.SetActive(true);
        selectUI.present = present;
    }
}

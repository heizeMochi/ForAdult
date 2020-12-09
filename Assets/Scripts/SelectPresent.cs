using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectPresent : MonoBehaviour, IPointerClickHandler
{
    public Define.Present present = Define.Present.NONE;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"{present}를 정말로 선물하시겠습니까?");
    }
}

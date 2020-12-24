using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPresent : MonoBehaviour
{
    public string presentName;
    public Define.Present present = Define.Present.NONE;
    [SerializeField]
    SelectedPresent selectUI;

    private void OnEnable()
    {
        selectUI = GameObject.Find("Canvas").transform.Find("SelectedPresent").GetComponent<SelectedPresent>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 100f);

            if (hit.collider.CompareTag("Present"))
            {
                selectUI.presentName = hit.collider.GetComponent<SelectPresent>().presentName;
                selectUI.present = hit.collider.GetComponent<SelectPresent>().present;
                selectUI.gameObject.SetActive(true);
            }
        }
    }
}

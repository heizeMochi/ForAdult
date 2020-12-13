using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedPresent : MonoBehaviour
{
    Text text;
    Button yesBtn;
    Button noBtn;

    public string presentName = "";
    public Define.Present present = Define.Present.NONE;

    private void Awake()
    {
        text = transform.GetChild(0).GetComponent<Text>();
        yesBtn = transform.GetChild(1).GetComponent<Button>();
        noBtn = transform.GetChild(2).GetComponent<Button>();
    }

    private void OnEnable()
    {
        text.text = $"{presentName} 을(를) 선물로 선택하시겠습니까?";
        yesBtn.onClick.RemoveAllListeners();
        noBtn.onClick.RemoveAllListeners();
        yesBtn.onClick.AddListener(YesButton);
        noBtn.onClick.AddListener(NoButton);
    }
    
    public void YesButton()
    {
        SceneChange sceneChange = GetComponent<SceneChange>();
        Managers.Game.Present = present;
        sceneChange.SceneChanged("Investigate");
    }

    public void NoButton()
    {
        gameObject.SetActive(false);
    }
}

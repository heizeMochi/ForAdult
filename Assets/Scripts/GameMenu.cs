using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    Fade fade;

    private void Start()
    {
        Managers.Sound.BGMPlay("GameMenu", 0.2f);
    }

    public void GameStart()
    {
        fade.gameObject.SetActive(true);
        fade.SceneName = "Investigate";
    }
}
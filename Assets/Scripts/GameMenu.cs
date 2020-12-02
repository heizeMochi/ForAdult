using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    private void Start()
    {
        Managers.Sound.BGMPlay("GameMenu", 0.2f);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Investigate");
    }
}
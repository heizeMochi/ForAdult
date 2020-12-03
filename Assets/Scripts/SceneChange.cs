using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    Fade fade;
    Button btn;

    private void Start()
    {
        fade = GameObject.FindObjectOfType<Fade>(true);
    }

    public void SceneChanged(string scenename)
    {
        fade.SceneName = scenename;
        fade.gameObject.SetActive(true);
    }
}

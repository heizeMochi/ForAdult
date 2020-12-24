using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    SpriteRenderer spr;
    public string SceneName;
    [SerializeField]
    Define.Fade state = Define.Fade.FadeIN;

    private void Awake()
    {
        spr = this.GetComponent<SpriteRenderer>();
        DontDestroyOnLoad(gameObject);
    }

    private void OnEnable()
    {
        spr.color = new Color(0, 0, 0, 0);
        state = Define.Fade.FadeIN;
    }

    void Update()
    {
        switch (state)
        {
            case Define.Fade.FadeIN:
                spr.color = new Color(0, 0, 0, spr.color.a + 0.5f * Time.deltaTime);
                if (spr.color.a > 0.9f)
                {
                    state = Define.Fade.FadeOUT;
                    SceneManager.LoadScene(SceneName);
                    Managers.Sound.SoundStop();
                }
                break;
            case Define.Fade.FadeOUT:
                spr.color = new Color(0, 0, 0, spr.color.a - 0.5f * Time.deltaTime);
                if(spr.color.a <= 0.01f)
                    gameObject.SetActive(false);
                break;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    Collider2D col;

    float onTime = 3;
    float randTime = 0;
    float elapsedTime = 0;

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (col.enabled)
        {
            if(onTime < elapsedTime)
            {
                Managers.Sound.SoundStop();
                EnabledFalse();
            }
        }

        if(randTime < elapsedTime)
        {
            Managers.Sound.SoundPlay("Warning");
            col.enabled = true;
            elapsedTime = 0f;
        }
    }

    private void Start()
    {
        col = GetComponent<Collider2D>();
        Invoke("EnabledFalse", onTime);
    }

    void EnabledFalse()
    {
        col.enabled = false;
        randTime = Random.Range(5, 10);
        elapsedTime = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Fade fade = GameObject.FindObjectOfType<Fade>(true);
            fade.gameObject.SetActive(true);
        }
    }
}
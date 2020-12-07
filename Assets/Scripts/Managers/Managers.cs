using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;
    public static Managers Instance { get { Init(); return s_instance; } }

    SoundManager sound = new SoundManager();
    public static SoundManager Sound { get { return Instance.sound; } }

    GameManager game = new GameManager();
    public static GameManager Game { get { return Instance.game; } }

    TalkManager talk = new TalkManager();
    public static TalkManager Talk { get { Instance.talk.Init();  return Instance.talk; } }
    
    static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null){
                go = new GameObject("@Managers");
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();

            s_instance.sound.Init();
            s_instance.game.Init();
        }
    }

    public void TalkInit(TalkManager mng)
    {
        talk = mng;
        Debug.Log(mng);
        Debug.Log(talk);
    }
}
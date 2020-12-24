using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    Dictionary<string, AudioClip> SoundList = new Dictionary<string, AudioClip>();
    Dictionary<string, AudioClip> BGMList = new Dictionary<string, AudioClip>();

    AudioSource BGMSource, SoundSource;

    public void Init()
    {
        if(BGMSource == null)
        {
            GameObject go = GameObject.Find("@Managers");
            BGMSource = go.AddComponent<AudioSource>();
            SoundSource = go.AddComponent<AudioSource>();
        }
        BGMInit();
        SoundInit();
    }

    void BGMInit()
    {
        AudioClip[] clips = Resources.LoadAll<AudioClip>("Sound/BGM");

        for (int i = 0; i < clips.Length; i++)
        {
            BGMList.Add(clips[i].name, clips[i]);
        }
    }

    void SoundInit()
    {
        AudioClip[] clips = Resources.LoadAll<AudioClip>("Sound/SFX");

        for (int i = 0; i < clips.Length; i++)
        {
            SoundList.Add(clips[i].name, clips[i]);
        }
    }

    public void BGMPlay(string name, float vol = 1)
    {
        BGMSource.clip = BGMList[name];
        BGMSource.loop = true;
        BGMSource.volume = vol;
        BGMSource.Play();
    }

    public void SoundPlay(string name, float vol = 1)
    {
        if (SoundSource.isPlaying)
            return;
        SoundSource.clip = SoundList[name];
        SoundSource.loop = true;
        SoundSource.volume = vol;
        SoundSource.Play();
    }

    public void SoundStop()
    {
        SoundSource.Stop();
    }
}
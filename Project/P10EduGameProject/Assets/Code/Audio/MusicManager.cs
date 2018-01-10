using UnityEngine.Audio;
using System;
using UnityEngine;

public class MusicManager : Singleton<MusicManager> {

    [SerializeField]
    private Sound[] _Soundsarray;

    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(gameObject);

        foreach (var s in _Soundsarray)
        {
            s._AudioSource = gameObject.AddComponent<AudioSource>();
            s._AudioSource.clip = s._Clip;

            s._AudioSource.volume = s._Volume;
            s._AudioSource.pitch = s._Pitch;
            s._AudioSource.loop = s._Loop;
        }
    }

    private void Start()
    {
        PlaySound("Theme");
    }

    public void PlaySound(string nameAudio)
    {
        Sound s = Array.Find(_Soundsarray, sound => sound._AudioName == nameAudio);

        if (s == null)
        {
            return;
        }

        s._AudioSource.Play();
    }
}

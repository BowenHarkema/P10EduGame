using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string _AudioName;

    public AudioClip _Clip;

    public bool _Loop;

    [Range(0f,1f)]
    public float _Volume;

    [Range(.1f,3f)]
    public float _Pitch;

    [HideInInspector]
    public AudioSource _AudioSource;
}

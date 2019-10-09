using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource myAudioSource;

    public AudioClip collectTpSound;

    public AudioClip hazardSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void PlayCollectTpSound()
    {
        myAudioSource.clip = collectTpSound;
        myAudioSource.Play();
    }

    public void PlayHazardSound()
    {
        myAudioSource.clip = hazardSound;
        myAudioSource.Play();
    }
}

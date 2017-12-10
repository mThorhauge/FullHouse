using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioSource bgMusicSource;
    public static SoundManager instance = null;

    // Use this for initialization
    void Awake()
    {
        //set instance to this
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PlayClip(AudioClip clip)
    {
        //consider randomizing pitch a little like in tutorial vid?
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

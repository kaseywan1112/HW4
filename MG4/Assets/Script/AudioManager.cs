using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;

    public AudioClip Flap;
    public AudioClip Score;
    public AudioClip Death;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PlayFlapSound()
    {
        if (Flap != null)
        {
            audioSource.PlayOneShot(Flap);
        }
    }
    public void PlayScoreSound()
    {
        if (Score != null)
        {
            audioSource.PlayOneShot(Score);
        }
    }
    public void PlayDeathSound()
    {
        if (Death != null)
        {
            audioSource.PlayOneShot(Death);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

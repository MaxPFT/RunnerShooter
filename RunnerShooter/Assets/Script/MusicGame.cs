using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicGame : MonoBehaviour
{
    private static MusicGame instance = null;
    public AudioClip[] musicClips;
    [SerializeField] private AudioSource audioSource;
    private int currentTrackIndex = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            PlayNextTrack();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextTrack();
        }
    }

    void PlayNextTrack()
    {
        if (musicClips.Length == 0)
            return;

        audioSource.clip = musicClips[currentTrackIndex];
        audioSource.Play();
        currentTrackIndex = (currentTrackIndex + 1) % musicClips.Length;
    }
}

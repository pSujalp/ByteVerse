using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
public AudioClip[] songs;

    private AudioSource audioSource;
    private AudioClip currentSong;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayRandomSong();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayRandomSong();
        }
    }

    void PlayRandomSong()
    {
        if (songs.Length == 0)
        {
            Debug.LogWarning("No songs assigned to the MusicPlayer.");
            return;
        }

        int randomIndex = Random.Range(0, songs.Length);
        currentSong = songs[randomIndex];
        audioSource.clip = currentSong;
        audioSource.Play();
    } 
    
}

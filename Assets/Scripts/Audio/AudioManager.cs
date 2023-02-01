using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    #region Fields
    [Header("Fields")]
    private AudioSource musicSource;
    private AudioSource musicSource2; // for transitioning one song to another without having to cut one completely
    private AudioSource sfxSource;

    private bool firstMusicSourceIsPlaying;
    #endregion
    
    private void Awake()
    {
        #region Static Instance
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Audio Manager in the scene.");
        }
        instance = this;
        #endregion
        // Make sure to not destroy this instance
        DontDestroyOnLoad(this.gameObject);

        // Create audio sources and save them as references
        musicSource= this.gameObject.AddComponent<AudioSource>();
        musicSource2 = this.gameObject.AddComponent<AudioSource>();
        sfxSource = this.gameObject.AddComponent<AudioSource>();

        // Loop the music tracks
        musicSource.loop = true;
        musicSource2.loop = true;
    }

    public static AudioManager GetInstance()
    {
        return instance;
    }

    public void PlayMusic(AudioClip musicClip)
    {
        // Determine which source is active
        AudioSource activeSource = (firstMusicSourceIsPlaying) ? musicSource : musicSource2; // ? = true : = false

        activeSource.clip = musicClip;
        activeSource.volume = 1;
        activeSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip); // PlayOneShot doesn't clip any existing audio
    }

    // Overload for PlaySFX for controlling the volume when necessary
    public void PlaySFX(AudioClip clip, float volume)
    {
        sfxSource.PlayOneShot(clip, volume);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour
{
    private static AudioManagerTest instance;

    [SerializeField] private AudioClip buttonClipSFX;
    [SerializeField] private AudioClip music1;
    [SerializeField] private AudioClip music2;

    private void Awake()
    {
        #region Static Instance
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene.");
        }
        instance = this;
        #endregion
    }

    public static AudioManagerTest GetInstance()
    {
        return instance;
    }

    public void PlayMenuMusic()
    {
        AudioManager.Instance.PlayMusic(music1);
        AudioManager.Instance.SetMusicVolume(0.1f);
    }
    public void PlayBattleMusic()
    {
        AudioManager.Instance.PlayMusic(music2);
        AudioManager.Instance.SetMusicVolume(0.1f);
    }

    // Examples of how to use

    // AudioManager.Instance.PlaySFX(buttonClickSFX, 1)
    // AudioManager.Instance.PlayMusic(music1);
    // AudioManager.Instance.PlayMusic(music2);
    // AudioManager.Instance.PlayMusicWithFade(music1);
    // AudioManager.Instance.PlayMusicWithFade(music2);
    // AudioManager.Instance.PlayMusicWithCrossFade(music1, 3.0f);
    // AudioManager.Instance.PlayMusicWithCrossFade(music2, 3.0f);
}

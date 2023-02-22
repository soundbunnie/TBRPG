using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour
{
    private static AudioManagerTest instance;

    [SerializeField] private AudioClip passCheckSFX;
    [SerializeField] private AudioClip failCheckSFX;
    [SerializeField] private AudioClip yaySFX;
    [SerializeField] private AudioClip menuMusic;
    [SerializeField] private AudioClip battleMusic;
    [SerializeField] private AudioClip encounterWinSFX;
    [SerializeField] private AudioClip pageTurnSFX;


    private void Awake()
    {
        #region Static Instance
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Audio Manager Test in the scene.");
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
        AudioManager.Instance.PlayMusic(menuMusic);
        AudioManager.Instance.SetMusicVolume(0.1f);
    }
    public void PlayBattleMusic()
    {
        AudioManager.Instance.PlayMusic(battleMusic);
        AudioManager.Instance.SetMusicVolume(0.1f);
    }
    
    public void PlayPassSFX()
    {
        AudioManager.Instance.PlaySFX(passCheckSFX, 0.1f);
    }

    public void PlayFailSFX()
    {
        AudioManager.Instance.PlaySFX(failCheckSFX, 0.1f);
    }

    public void playYaySFX()
    {
        AudioManager.Instance.PlaySFX(yaySFX, 0.2f);
    }
    public void PageTurnSFX()
    {
        AudioManager.Instance.PlaySFX(pageTurnSFX, 0.1f);
    }

    public void WinEncounterSFX()
    {
        AudioManager.Instance.PlaySFX(encounterWinSFX, 0.1f);
        AudioManager.Instance.StopMusic();
    }

    public void TransitionMenuToBattleMusic()
    {
        AudioManager.Instance.PlayMusicWithFade(battleMusic, 0.5f, 0.1f);
    }

    // Examples of how to use

    // AudioManager.Instance.PlaySFX(buttonClickSFX, 1)
    // AudioManager.Instance.PlayMusic(menuMusic);
    // AudioManager.Instance.PlayMusic(battleMusic);
    // AudioManager.Instance.PlayMusicWithFade(menuMusic);
    // AudioManager.Instance.PlayMusicWithFade(battleMusic);
    // AudioManager.Instance.PlayMusicWithCrossFade(menuMusic, 3.0f);
    // AudioManager.Instance.PlayMusicWithCrossFade(battleMusic, 3.0f);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerTest : MonoBehaviour
{
    [SerializeField] private AudioClip buttonClipSFX;
    [SerializeField] private AudioClip music1;
    [SerializeField] private AudioClip music2;

    // Examples of how to use

    // AudioManager.Instance.PlaySFX(buttonClickSFX, 1)
    // AudioManager.Instance.PlayMusic(music1);
    // AudioManager.Instance.PlayMusic(music2);
    // AudioManager.Instance.PlayMusicWithFade(music1);
    // AudioManager.Instance.PlayMusicWithFade(music2);
    // AudioManager.Instance.PlayMusicWithCrossFade(music1, 3.0f);
    // AudioManager.Instance.PlayMusicWithCrossFade(music2, 3.0f);
}

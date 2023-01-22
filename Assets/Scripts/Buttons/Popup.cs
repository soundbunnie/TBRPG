using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject popupPanel;

    private static Popup instance;

    public void Awake()
    {
        instance = this;
        popupPanel.SetActive(false);
    }

    public static Popup GetInstance()
    {
        return instance;
    }

    public void OpenPopup()
    {
        popupPanel.SetActive(true);
    }
    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.2f).setOnComplete(DestroyMe);
    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }
}

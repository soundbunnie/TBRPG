using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject popupPanel;

    public void Awake()
    {
        popupPanel.SetActive(false);
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

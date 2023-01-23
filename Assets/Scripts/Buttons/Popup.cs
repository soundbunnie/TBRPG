using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    [SerializeField] private GameObject popupPanel;
    [SerializeField] private TextMeshProUGUI popupText;

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

    public void OpenPopup(string popupLine)
    {
        popupText.text = popupLine;
        popupPanel.SetActive(true);
    }
    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.2f).setOnComplete(HidePopup);
    }

    public void HidePopup()
    {
        popupPanel.SetActive(false);
    }
}

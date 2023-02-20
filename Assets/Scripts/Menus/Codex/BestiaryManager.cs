using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestiaryManager : MonoBehaviour
{
    #region Static Instance
    private static BestiaryManager instance;
    #endregion
    [SerializeField] private GameObject[] Entries;
    private TextMeshProUGUI[] entryText;

    private void Awake()
    {
        #region Static Instance
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Bestiary Manager in the scene.");
        }
        instance = this;
        #endregion
    }

    private void Start()
    {
        entryText = new TextMeshProUGUI[Entries.Length]; // Set entrytext to an array of same length as entries
    }

    public static BestiaryManager GetInstance()
    {
        return instance;
    }
    public void EnableEntry(string monsterId)
    {
        switch(monsterId)
        {
            case ("MrFrog"):
                Entries[0].GetComponent<TabButton>().EnableTab();
                entryText[0] = Entries[0].GetComponentInChildren<TextMeshProUGUI>(); // initialize corresponding text using index of that choice so they match
                entryText[0].text = "Mr. Frog";
                break;
        }
    }
}

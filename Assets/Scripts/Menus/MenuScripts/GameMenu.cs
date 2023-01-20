using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;

public class GameMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI PlayerTitleText;
    public void OnClick_Location()
    {
        MenuManager.OpenMenu(Menu.LOCATION_MENU, gameObject);
    }
    public void OnClick_Settings()
    {
        MenuManager.OpenMenu(Menu.SETTINGS_MENU, gameObject);
    }

    public void OnClick_Save()
    {
        MenuManager.OpenMenu(Menu.SAVE_MENU, gameObject);
    }

    public void OnClick_Load()
    {
        MenuManager.OpenMenu(Menu.LOAD_MENU, gameObject);
    }

    public void OnClick_Character()
    {
        MenuManager.OpenMenu(Menu.CHARACTER_MENU, gameObject);
    }

    public void OnClick_History()
    {
        MenuManager.OpenMenu(Menu.HISTORY_MENU, gameObject);
    }

    public void OnClick_Items()
    {
        MenuManager.OpenMenu(Menu.ITEMS_MENU, gameObject);
    }

    public void OnClick_Stats()
    {
        MenuManager.OpenMenu(Menu.STATS_MENU, gameObject);
    }

    private void Update()
    {
        var player_title = ((Ink.Runtime.StringValue)DialogueManager
            .GetInstance()
            .GetVariableState("player_title")).value;
        PlayerTitleText.text = player_title.ToString();
    }
}

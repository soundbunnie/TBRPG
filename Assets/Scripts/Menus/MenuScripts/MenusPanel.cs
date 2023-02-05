using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;

public class MenusPanel : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI PlayerTitleText;
    public void OnClick_Location()
    {
        MenuManager.OpenMenu(Menu.LOCATION_MENU, gameObject);
    }
    public void OnClick_Game()
    {
        MenuManager.OpenMenu(Menu.GAME_MENU, gameObject);
    }
    public void OnClick_Codex()
    {
        MenuManager.OpenMenu(Menu.CODEX_MENU, gameObject);
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
        MenuManager.OpenMenu(Menu.INVENTORY_MENU, gameObject);
    }

    public void OnClick_Stats()
    {
        MenuManager.OpenMenu(Menu.STATS_MENU, gameObject);
    }
}

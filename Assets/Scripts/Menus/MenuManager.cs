using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static bool IsInitialized { get; private set; }
    public static GameObject gameMenu,
        menusPanel,
        codexMenu,
        locationMenu,
        settingsMenu,
        saveMenu,
        loadMenu,
        characterMenu,
        historyMenu,
        inventoryMenu,
        statsMenu;

    public static void Init()
    {
        GameObject canvas = GameObject.Find("Canvas");
        GameObject menus = GameObject.Find("Menus");
        menusPanel = menus.transform.Find("MenusPanel").gameObject;
        gameMenu = menus.transform.Find("GameMenu").gameObject;
        codexMenu = menus.transform.Find("CodexMenu").gameObject;
        locationMenu = menus.transform.Find("LocationMenu").gameObject;
        settingsMenu = menus.transform.Find("SettingsMenu").gameObject;
        saveMenu = menus.transform.Find("SaveMenu").gameObject;
        loadMenu = menus.transform.Find("LoadMenu").gameObject;
        characterMenu = menus.transform.Find("CharacterMenu").gameObject;
        historyMenu = menus.transform.Find("HistoryMenu").gameObject;
        inventoryMenu = menus.transform.Find("InventoryMenu").gameObject;
        statsMenu = menus.transform.Find("StatsMenu").gameObject;

        IsInitialized = true;
    }

    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!IsInitialized)
        {
            Init();
        }
        switch(menu)
        {
            case Menu.GAME_MENU:
                gameMenu.SetActive(true);
                break;
            case Menu.CODEX_MENU:
                codexMenu.SetActive(true);
                break;
            case Menu.LOCATION_MENU:
                locationMenu.SetActive(true);
                break;
            case Menu.SETTINGS_MENU:
                settingsMenu.SetActive(true);
                break;
            case Menu.SAVE_MENU:
                saveMenu.SetActive(true);
                break;
            case Menu.LOAD_MENU:
                loadMenu.SetActive(true);
                break;
            case Menu.CHARACTER_MENU:
                characterMenu.SetActive(true);
                break;
            case Menu.HISTORY_MENU:
                historyMenu.SetActive(true);
                break;
            case Menu.INVENTORY_MENU:
                inventoryMenu.SetActive(true);
                break;
            case Menu.STATS_MENU:
                statsMenu.SetActive(true);
                break;
        }
        if (callingMenu != menusPanel)
        {
            callingMenu.SetActive(false);
        }
    }
}

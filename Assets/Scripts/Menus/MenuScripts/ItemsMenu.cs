using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsMenu : MonoBehaviour
{
    public void OnClick_Back()
    {
        MenuManager.OpenMenu(Menu.GAME_MENU, gameObject);
    }
}

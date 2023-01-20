using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class CharacterMenu : MonoBehaviour
{
    private Story currentStory;

    public void OnClick_Back()
    {
        MenuManager.OpenMenu(Menu.GAME_MENU, gameObject);
    }

    private void Start()
    {
        var skills = DialogueManager.GetInstance().GetVariableState("Skills");
        var player_class = DialogueManager.GetInstance().GetVariableState("player_class");

        Debug.Log(skills);
        Debug.Log(player_class);
    }
}


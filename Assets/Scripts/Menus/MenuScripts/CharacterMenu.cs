using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;

public class CharacterMenu : MonoBehaviour
{
    private Story currentStory;
    [SerializeField] private GameObject SkillsPanel;
    [SerializeField] private TextMeshProUGUI SkillsList;

    public void OnClick_Back()
    {
        MenuManager.OpenMenu(Menu.GAME_MENU, gameObject);
    }

    private void Update()
    {
        var skills = ((Ink.Runtime.ListValue)DialogueManager
            .GetInstance()
            .GetVariableState("Skills")).value;
        var player_class = ((Ink.Runtime.StringValue)DialogueManager
            .GetInstance()
            .GetVariableState("player_class")).value;

        SkillsList.text = skills.ToString();
    }
}


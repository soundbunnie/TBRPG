using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus_Tab_Group : MonoBehaviour
{
    public List<Menus_Tab_Button> tabButtons;
    public Menus_Tab_Button selectedTab;
    public List<GameObject> objectsToSwap;

    public void Subscribe(Menus_Tab_Button button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<Menus_Tab_Button>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(Menus_Tab_Button button)
    {
        ResetTabs();
    }

    public void OnTabExit(Menus_Tab_Button button)
    {
        ResetTabs();
    }

    public void OnTabSelected(Menus_Tab_Button button)
    {
        selectedTab = button;
        ResetTabs();
        int index = button.transform.GetSiblingIndex();
        for(int i = 0; i < objectsToSwap.Count; i++ )
        {
            if (i == index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach(Menus_Tab_Button button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab) { continue;  }
        }
    }
}

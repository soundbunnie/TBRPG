using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public Sprite tabIdle;
    public Sprite tabHover;

    internal void Subscribe(Menus_Tab_Button menus_Tab_Button)
    {
        throw new NotImplementedException();
    }

    internal void OnTabSelected(Menus_Tab_Button menus_Tab_Button)
    {
        throw new NotImplementedException();
    }

    internal void OnTabEnter(Menus_Tab_Button menus_Tab_Button)
    {
        throw new NotImplementedException();
    }

    internal void OnTabExit(Menus_Tab_Button menus_Tab_Button)
    {
        throw new NotImplementedException();
    }

    public Sprite tabActive;
    public TabButton selectedTab;
    public List<GameObject> objectsToSwap;

    public void Subscribe(TabButton button)
    {
        if (tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }

        tabButtons.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            button.background.sprite = tabHover;
        }
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button)
    {
        if (selectedTab != null)
        {
            selectedTab.Deselect();
        }

        selectedTab = button;

        selectedTab.Select();

        ResetTabs();
        button.background.sprite = tabActive;
        int index = button.transform.GetSiblingIndex(); // Index of pages should match the index of the tabs
        for(int i = 0; i < objectsToSwap.Count; i++)
        {
            // Set page to active if it's the index, if not, set it to inactive
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
        foreach(TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab) { continue; }
            button.background.sprite = tabIdle;
        }
    }
}

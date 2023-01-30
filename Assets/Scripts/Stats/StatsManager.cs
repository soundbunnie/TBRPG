using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    Dictionary<string, int> playerStats = new Dictionary<string, int>()
    {
        // Physical Stats
        {"Health", 20},
        {"Strength", 1},
        {"Stealth", 1},

        // Mental Stats
        {"Influence", 1},
        {"Empathy", 1},
        {"Logic", 1},
        {"Willpower", 1},
        {"Introspection", 1},

        // Passive Stats
        {"Perception", 1},
        {"History", 1}
    };
}

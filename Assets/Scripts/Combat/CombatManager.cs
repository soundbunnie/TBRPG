using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    #region Fields
    public bool inCombat = false;
    #endregion

    #region Static instance
    private static CombatManager instance;
    public static CombatManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<CombatManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned CombatManager", typeof(CombatManager)).GetComponent<CombatManager>();
                }
            }

            return instance;
        }
        private set
        {
            instance = value;
        }
    }
#endregion
    public void StartCombat()
    {
        inCombat = true;
    }

    public void FinishCombat()
    {

    }
}

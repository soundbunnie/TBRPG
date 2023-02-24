using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatManager : MonoBehaviour
{
    #region Fields
    [SerializeField] GameObject combatUI;
    [SerializeField] GameObject actionMenu;
    [SerializeField] GameObject[] enemyList;

    public PlayerData playerData;
    public EnemyData[] enemyData;
    private TextMeshProUGUI[] enemyListText;
    private TextMeshProUGUI[] enemyHPText;

    List<string> _turnOrder = new List<string>();

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
        combatUI.SetActive(true);
        DisplayEnemies();
        EstablishTurnOrder();
    }
    private void DisplayEnemies()
    {
        enemyListText = new TextMeshProUGUI[enemyList.Length];
        int index = 0;
        foreach (EnemyData enemy in enemyData)
        {
            enemyList[index].gameObject.SetActive(true);
            enemyListText = enemyList[index].GetComponentsInChildren<TextMeshProUGUI>();

            enemyListText[0].text = enemyData[index].enemyName;
            enemyListText[1].text = enemyData[index].currentHealth.ToString();

            index++;
        }
    }

    private void DoTurn()
    {
        if (_turnOrder[0] == "Player")
        {
            actionMenu.SetActive(true);
        }
        else
        {
            actionMenu.SetActive(false);
        }
    }

    private void EstablishTurnOrder()
    {
        if (playerData.speed > enemyData[0].speed)
        {
            _turnOrder.Add("Player");
            _turnOrder.Add(enemyData[0].enemyName);
        }
    }

    public void PlayerAttack()
    {
        int enemyIndex = 0;
        int attackRoll = Random.Range(1, 6);
        int damageRoll = Random.Range(1, 6);
        EnemyReceiveDamage(enemyIndex, attackRoll, damageRoll);
    }

    private void EnemyReceiveDamage(int enemyIndex, int attackRoll, int damageRoll)
    {
        if (attackRoll > enemyData[enemyIndex].toHit)
        {
            enemyData[enemyIndex].currentHealth -= damageRoll;
            DisplayEnemies();
        }
    }

    public void FinishCombat()
    {
        combatUI.SetActive(false);
        // Reset all enemies hp
        int index = 0;
        foreach (EnemyData enemy in enemyData)
        {
            enemy.currentHealth = enemy.maxHealth;
            index++;
        }
    }
}

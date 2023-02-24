using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    List<CreatureBase> _turnOrder = new List<CreatureBase>();

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
        // Add player to turn order
        _turnOrder.Add(playerData);
        AddEnemies();
        SetTurnOrder();
    }
    private void AddEnemies()
    {
        enemyListText = new TextMeshProUGUI[enemyList.Length];
        int index = 0;
        foreach (EnemyData enemy in enemyData)
        {
            // Set enemy in the UI
            enemyList[index].gameObject.SetActive(true);
            enemyListText = enemyList[index].GetComponentsInChildren<TextMeshProUGUI>();

            enemyListText[0].text = enemyData[index].creatureName;
            enemyListText[1].text = enemyData[index].currentHealth.ToString();

            // Add enemy to turn order
            _turnOrder.Add(enemyData[index]);
            index++;
        }
    }

    private void SetTurnOrder()
    {
        List<CreatureBase> sortedList = _turnOrder.OrderByDescending(creature => creature.speed).ToList(); // Sort turn order by creature speed
        _turnOrder = sortedList;
        Debug.Log(_turnOrder[0].creatureName + " " + _turnOrder[1].creatureName + " " + _turnOrder[2].creatureName);
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
            AddEnemies();
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

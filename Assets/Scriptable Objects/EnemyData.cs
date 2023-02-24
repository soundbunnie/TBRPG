using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy/Enemy")]
public class EnemyData : EnemyBase
{
    public string enemyName;
    public string attackStat;
    public int maxHealth;
    public int currentHealth;
    public int toHit;
    public int strength;
    public int dexterity;
    public int willpower;
    public int intelligence;
    public int influence;
    public int awareness;
    public int speed;

    public override void DoTurn()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Player/Player Data")]
public class PlayerData : PlayerBase
{
    public int maxHealth;
    public int currentHealth;
    public string attackStat;
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
        // Do turn
    }
}

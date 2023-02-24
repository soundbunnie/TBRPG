using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Stats", menuName = "Parameters/Character Stats")]
public class Stats : ScriptableObject
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
}

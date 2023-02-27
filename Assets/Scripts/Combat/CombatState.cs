using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CombatState
{
    protected readonly CombatManager _combatManager;

    public CombatState(CombatManager combatManager)
    {
        _combatManager = combatManager;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator HandleTurnOrder()
    {
        yield break;
    }

    public virtual IEnumerator PlayerTurn()
    {
        yield break;
    }

    public virtual IEnumerator EnemyTurn()
    {
        yield break;
    }

    public virtual IEnumerator CombatDialogue()
    {
        yield break;
    }
}

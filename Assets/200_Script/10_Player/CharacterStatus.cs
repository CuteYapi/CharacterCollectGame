using UnityEngine;
using System.Collections.Generic;

public class CharacterStatus : MonoBehaviour
{
    public int AttackResult {  get; private set; } 
    public Dictionary<StatusReason, int> AttackReason = new Dictionary<StatusReason, int>();

    public int Defense { get; private set; }
    public int Health { get; private set; }

    public void AddAttack(StatusReason reason, int point)
    {
        if(AttackReason.TryAdd(reason, point) == false)
        {
            AttackReason[reason] = point;
        }
    }

    public void SetAttackResult()
    {
        AttackResult = 0;
        foreach(var reason in AttackReason)
        {
            AttackResult += reason.Value;
        }
    }
}

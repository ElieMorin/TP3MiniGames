using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoffee : PlayerState
{
    private PlayerState m_BaseState;
    public PlayerCoffee(PlayerBehaviour behaviour) : base(behaviour)
    {
        m_BaseState = m_AttachedBehaviour.GetComponent<PlayerRoaming>();
    }

    public override void execute()
    {
        m_AttachedBehaviour.inventory.AddToInventory(EMiniGamesRewards.DONUT);
        m_AttachedBehaviour.ChangeState(m_BaseState);
    }
}

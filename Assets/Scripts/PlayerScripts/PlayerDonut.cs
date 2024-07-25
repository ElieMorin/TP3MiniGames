using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDonut : PlayerState
{
    private PlayerState m_BaseState;
    public PlayerDonut(PlayerBehaviour behaviour) : base(behaviour)
    {
        m_BaseState = m_AttachedBehaviour.GetComponent<PlayerRoaming>();
    }

    public override void execute()
    {
        m_AttachedBehaviour.inventory.AddToInventory(EMiniGamesRewards.DONUT);
        m_AttachedBehaviour.ChangeState(m_BaseState);
    }
}

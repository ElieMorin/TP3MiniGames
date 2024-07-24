using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerRoaming : PlayerState
{
    public PlayerRoaming(PlayerBehaviour behaviour) : base(behaviour)
    {

    }

    public override void execute()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_AttachedBehaviour.inventory.AddToInventory(EMiniGamesRewards.COFFEE);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            m_AttachedBehaviour.inventory.AddToInventory(EMiniGamesRewards.DONUT);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            m_AttachedBehaviour.inventory.AddToInventory(EMiniGamesRewards.TROPHIE);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            m_AttachedBehaviour.inventory.LoadInventory();
        }
    }
}
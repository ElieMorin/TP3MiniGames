using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class PlayerRoaming : PlayerState
{
    public PlayerRoaming(PlayerBehaviour behaviour) : base(behaviour)
    {

    }

    public override void execute(UI m_UI)
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            m_UI.AddMoney(Color.blue);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            m_UI.AddMoney(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            m_UI.AddMoney(Color.green);
        }
    }
}

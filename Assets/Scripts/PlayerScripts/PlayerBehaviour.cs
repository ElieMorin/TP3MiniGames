using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public Inventory inventory = new Inventory();

    private PlayerState m_CurrentState;
    
    void Awake()
    {
        m_CurrentState = new PlayerRoaming(this);
    }

    void Update()
    {
        m_CurrentState.execute();   
    }

    public void ChangeState(PlayerState state)
    {
        m_CurrentState = state;
    }

    public void EnterMiniGame(Enum game)
    {
        switch (game)
        {
            case EMiniGame.RUN:
                m_CurrentState = new PlayerChampion(this);
                break;
            case EMiniGame.COFFEE:
                m_CurrentState = new PlayerCoffee(this);
                break;
            case EMiniGame.BREAD:
                m_CurrentState = new PlayerDonut(this);
                break;
        }
    }
}

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
}

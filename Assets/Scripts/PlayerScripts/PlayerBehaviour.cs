using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private PlayerState m_CurrentState;

    void Start()
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

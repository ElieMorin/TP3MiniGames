using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private UI m_UI;

    private PlayerState m_CurrentState;
    
    void Start()
    {
        m_CurrentState = new PlayerRoaming(this);
    }

    void Update()
    {
        m_CurrentState.execute(m_UI);   
    }

    public void ChangeState(PlayerState state)
    {
        m_CurrentState = state;
    }
}

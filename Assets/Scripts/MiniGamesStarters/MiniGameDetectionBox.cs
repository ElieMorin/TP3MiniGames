using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum EMiniGame
{
    RUN,
    COFFEE,
    BREAD,
}

public class MiniGameDetectionBox : MonoBehaviour
{
    [SerializeField] private EMiniGame m_MiniGame;

    private void OnTriggerStay(Collider other)
    {
        PlayerBehaviour m_PlayerBehaviour = other.GetComponent<PlayerBehaviour>();
        if (m_PlayerBehaviour != null && Input.GetKeyDown(KeyCode.Space))
        {
            m_PlayerBehaviour.EnterMiniGame(m_MiniGame);
        }
    }
}

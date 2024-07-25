using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.AI;

public class PlayerRoaming : PlayerState
{
    private NavMeshAgent m_Agent;

    public PlayerRoaming(PlayerBehaviour behaviour) : base(behaviour)
    {
        m_Agent = m_AttachedBehaviour.GetComponent<NavMeshAgent>();
    }

    public override void execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayFromCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(rayFromCamera, out RaycastHit info))
            {
                m_Agent.SetDestination(info.point);
            }
        }
    }
}
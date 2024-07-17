using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EEvents
{
    ON_ITEM_ADDED_TO_INVENTORY,
    ON_MINIGAME_ENDED,
    ON_GAME_WON,
    ON_LOAD_GAME
}

public class EventSystem
{
    private static EventSystem m_Instance;

    private Dictionary<EEvents, Action<Dictionary<string, object>>> m_Events;

    private EventSystem()
    {
        m_Events = new Dictionary<EEvents, Action<Dictionary<string, object>>>();
    }

    public static EventSystem GetInstance()
    {
        if(m_Instance == null)
        {
            m_Instance = new EventSystem();
        }
        return m_Instance;
    }

    public void SubscribeTo(EEvents eventId, Action<Dictionary<string, object>> func)
    {
        if (m_Events.ContainsKey(eventId))
        {
            m_Events[eventId] += func;
        }
        else
        {
            m_Events.Add(eventId, func);
        }
    }
    public void UnSubscribeFrom(EEvents eventId, Action<Dictionary<string, object>> func)
    {
        if (!m_Events.ContainsKey(eventId))
        {
            m_Events[eventId] -= func;
        }
    }
    public void TriggerEvents(EEvents eventId, Dictionary<string,object> parameters)
    {
        if (m_Events.ContainsKey(eventId))
        {
            m_Events[eventId].Invoke(parameters);
        }
    }
}

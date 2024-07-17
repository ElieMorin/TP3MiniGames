using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public enum EMiniGamesRewards
{
    EMPTY,
    COFFEE,
    DONUT,
    TROPHIE,
}

public class Inventory
{
    private List<EMiniGamesRewards> m_Inventory = new List<EMiniGamesRewards>();

    public Inventory()
    {
        for (int i = 0; i < 5; i++)
        {
            m_Inventory.Add(EMiniGamesRewards.EMPTY);
        }
    }

    public List<EMiniGamesRewards> GetInventory()
    {
        return m_Inventory;
    }

    public void AddToInventory(EMiniGamesRewards prizeWon)
    {
        for(int i = 0;i < m_Inventory.Count;i++)
        {
             if (m_Inventory[i] == EMiniGamesRewards.EMPTY)
             {
                 m_Inventory[i] = prizeWon; 
                 break;
             }
        }

        SaveSystem.SaveGame(this);

        Dictionary<string, object> eventParams = new Dictionary<string, object>();
        eventParams.Add("ItemList", m_Inventory);
        EventSystem.GetInstance().TriggerEvents(EEvents.ON_ITEM_ADDED_TO_INVENTORY, eventParams);
    }

    public void LoadInventory()
    {
        SaveData data = SaveSystem.LoadGame();
        m_Inventory = data.m_SavedInventory;
    }
}

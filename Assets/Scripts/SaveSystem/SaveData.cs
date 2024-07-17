using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SaveData
{
    public List<EMiniGamesRewards> m_SavedInventory = new List<EMiniGamesRewards>();

    public SaveData(Inventory inventory)
    {
        m_SavedInventory = inventory.GetInventory();
    }
}

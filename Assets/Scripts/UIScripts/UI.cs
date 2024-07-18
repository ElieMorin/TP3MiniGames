using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct InventoryItems
{
    public EMiniGamesRewards Game;
    public Sprite Icon;
}

public class UI : MonoBehaviour
{
    [SerializeField] private List<InventoryItems> itemsStruct = new List<InventoryItems>();   

    [SerializeField] private List<Sprite> m_InventorySlots = new List<Sprite>();

    private void Start()
    {
        EventSystem.GetInstance().SubscribeTo(EEvents.ON_ITEM_ADDED_TO_INVENTORY, AddItem);
        EventSystem.GetInstance().SubscribeTo(EEvents.ON_LOAD_GAME, LoadInventory);
    }

    private void AddItem(Dictionary<string, object> parameters)
    {
        var o = parameters.Values;
        foreach (var item in o)
        {
            Debug.Log(item);
        }
        
        for (int i = 0;i < m_InventorySlots.Count;i++)
        {
            if (m_InventorySlots[i] == null)
            {
                m_InventorySlots[i] = itemsStruct;
                break;
            }
        }
    }

    private void LoadInventory(Dictionary<string, object> parameters)
    {

    }
}

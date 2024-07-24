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

    [SerializeField] private List<Image> m_InventorySlots = new List<Image>();

    private void Start()
    {
        EventSystem.GetInstance().SubscribeTo(EEvents.ON_ITEM_ADDED_TO_INVENTORY, AddItem);
        EventSystem.GetInstance().SubscribeTo(EEvents.ON_LOAD_GAME, LoadInventory);
    }

    private void AddItem(Dictionary<string, object> parameters)
    {
        Debug.Log("second checkpoint");
        Sprite imageToAdd = null;
        EMiniGamesRewards items = (EMiniGamesRewards)parameters["ItemsList"];

        for (int i = 0; i < itemsStruct.Count; i++)
        {
            if (itemsStruct[i].Game == items)
            {
                Debug.Log("third checkpoint");
                imageToAdd = itemsStruct[i].Icon;
            }
        }

        for (int i = 0; i < m_InventorySlots.Count; i++)
        {
            if (m_InventorySlots[i].sprite == null)
            {
                Debug.Log("last checkpoint");
                m_InventorySlots[i].sprite = imageToAdd;
                Debug.Log(m_InventorySlots[i]);
                break;
            }
        }
    }

    private void LoadInventory(Dictionary<string, object> parameters)
    {
        List<EMiniGamesRewards> inventoryToLoad = (List<EMiniGamesRewards>)parameters["ItemsList"];

        for(int i = 0; i < m_InventorySlots.Count; i++)
        {
            for(int j = 0;j < itemsStruct.Count; j++)
            {
                if (itemsStruct[j].Game == inventoryToLoad[i])
                {
                    m_InventorySlots[i].sprite = itemsStruct[j].Icon;
                }
            }    
        }
    }
}

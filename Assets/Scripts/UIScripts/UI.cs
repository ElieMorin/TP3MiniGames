using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private List<RawImage> m_InventorySlots = new List<RawImage>();

    private void Start()
    {
        EventSystem.GetInstance().SubscribeTo(EEvents.ON_ITEM_ADDED_TO_INVENTORY, AddItem);
    }

    private void AddItem(Dictionary<string, object> parameters)
    {
        Debug.Log("aa");
        for(int i = 0;i < m_InventorySlots.Count;i++)
        {
            Debug.Log("bb");
            if (m_InventorySlots[i].CompareTag("Untagged"))
            {
                Debug.Log("cc");
                m_InventorySlots[i].color = Color.black;
                m_InventorySlots[i].tag = "Tagged";
                break;
            }
        }
    }
}

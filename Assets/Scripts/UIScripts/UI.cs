using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] public List<RawImage> m_Slots = new List<RawImage>();
    public void AddMoney(Color color)
    {
        for (int i = 0; i < m_Slots.Count; i++)
        {
            if (m_Slots[i].color == Color.white)
            {
                m_Slots[i].color = color;
                break;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveSystem.SaveGame(this);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            SaveData data = SaveSystem.LoadGame();
            m_Slots[0].color = data.color1;
            m_Slots[1].color = data.color2;
            m_Slots[2].color = data.color3;
            m_Slots[3].color = data.color4;
            m_Slots[4].color = data.color5;
        }
    }
}

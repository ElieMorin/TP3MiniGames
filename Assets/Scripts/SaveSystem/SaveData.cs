using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SaveData
{
    public Color color1 = Color.white;
    public Color color2 = Color.white;
    public Color color3 = Color.white;
    public Color color4 = Color.white;
    public Color color5 = Color.white;

    public SaveData(UI ui)
    {
        color1 = ui.m_Slots[0].color;
        color2 = ui.m_Slots[1].color;
        color3 = ui.m_Slots[2].color;
        color4 = ui.m_Slots[3].color;
        color5 = ui.m_Slots[4].color;
    }
}

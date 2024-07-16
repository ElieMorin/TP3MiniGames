using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveSystem
{   
    public static void SaveGame(UI ui)
    {
        SaveData data = new SaveData(ui);
        string jsonContent = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/SaveGame.json", jsonContent);
    }

    public static SaveData LoadGame()
    {
        SaveData loadData = null;
        string path = Application.persistentDataPath + "/SaveGame.json";

        if(File.Exists(path))
        {
            string loadedJsonContent = File.ReadAllText(path);
            loadData = JsonUtility.FromJson<SaveData>(loadedJsonContent);
        }

        return loadData;
    }
}

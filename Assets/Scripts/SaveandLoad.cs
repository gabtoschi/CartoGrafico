using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveandLoad : MonoBehaviour {
    public List<LevelComplete> levels = new List<LevelComplete>();
    private SaveData data;
    public static SaveandLoad instance;
    private void Start() {
        
        Load();
    }
    private void OnLevelWasLoaded(int level) {
        Debug.Log("aaa");
        Save();
    }
    public void Save() {
        if(!Directory.Exists(Application.dataPath + "/saves")) {
            Directory.CreateDirectory(Application.dataPath + "/saves");
        }
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.dataPath + "/saves/SaveData.dat");

        CopySaveData();
        bf.Serialize(file, data);
        file.Close();
    }
    public void CopySaveData() {
        data.list1.Clear();
        foreach (LevelComplete b in levels) {
            
            data.list1.Add(b);
        }
    }
    public void Load() {
        if (File.Exists(Application.dataPath + "/saves/SaveData.dat")) {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.dataPath + "/saves/SaveData.dat", FileMode.Open);
            data = (SaveData)bf.Deserialize(file);

            CopyLoadData();
            file.Close();
        }
    }
    public void CopyLoadData() {
        levels.Clear();
        foreach (LevelComplete b in data.list1) {
            levels.Add(b);
        }

    }
    
}

[System.Serializable]
public class SaveData {
    public static SaveData saveInstance;
    public List<LevelComplete> list1 = new List<LevelComplete>();

}
[System.Serializable]
public class LevelComplete {
    public string levelName;
    public bool isCompleted;
}
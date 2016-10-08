using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveInformation : MonoBehaviour {

    public int maxHealth;
    public int currentHealth;
	
	public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save1.json");

        PlayerData data = new PlayerData();
        data.currentHealth = currentHealth;
        data.maxHealth = maxHealth;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/save1.json"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save1.json", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            maxHealth = data.maxHealth;
            currentHealth = data.currentHealth;
        }
    }
}

[Serializable]
class PlayerData
{
    public int maxHealth;
    public int currentHealth;
}

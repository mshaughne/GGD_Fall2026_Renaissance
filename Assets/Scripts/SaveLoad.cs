using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    private void Start()
    {
        Load();
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open
            (Application.persistentDataPath
            + "/PlayerStats.dat", FileMode.OpenOrCreate);
        // ^ instead of this, do the following:
        // PlayerStats stats = finding the player's gameobject,
        // then finding the PlayerStats component

        PlayerStats stats = new PlayerStats();
        stats.health = 50f;
        stats.playerName = "George";
        stats.playerLevel = 5;
        stats.levelsUnlocked = 3;

        bf.Serialize(file, stats);
        Debug.Log("Saved data to "
            + Application.persistentDataPath
            + "/PlayerStats.dat");

        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/PlayerStats.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/PlayerStats.dat", FileMode.Open);
            PlayerStats stats = new PlayerStats();

            stats = bf.Deserialize(file) as PlayerStats;
            // set all previously used data references to be equal to their new loaded info
            Debug.Log("Player name: " + stats.playerName);
            Debug.Log("Player level: " + stats.playerLevel);
        }
        else
        {
            Debug.Log("Save file does not exist.");
        }
    }
}

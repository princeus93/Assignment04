using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save
{
    public static void SaveScore(Score score)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.score";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(score);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static PlayerData LoadScore()
    {
        string path = Application.persistentDataPath + "player.score";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}

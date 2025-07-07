using System.IO;
using UnityEngine;

public class GameData
{
    public int chapter = 1;

    public int damage = 1;
    public int playerHP = 9;
    public int playerSpeed = 5;
}

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = new GameManager();
    public static GameManager instane => _instance;

    public GameData gameData;

    [ContextMenu("SaveData")]
    public void SaveData()
    {
        string data = JsonUtility.ToJson(gameData);
        string path = Path.Combine(Application.dataPath, data, "GameProgress.json");
        File.WriteAllText(path, data);
    }

    [ContextMenu("LoadData")]
    public void LoadData()
    {

        string path = Path.Combine(Application.dataPath, "GameProgress.json");

        if (!File.Exists(path))
        {
            SaveData();
        }
        string data = File.ReadAllText(path);
        gameData = JsonUtility.FromJson<GameData>(data);
    }
}

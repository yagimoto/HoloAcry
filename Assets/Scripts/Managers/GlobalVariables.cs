using UnityEngine;
using System.IO;

public class GlobalVariables : MonoBehaviour
{
    public static GameObject CurrentWork;
    public static string SaveFilePath;

    private void Awake()
    {
        SaveFilePath = Application.persistentDataPath + "/SaveFile.json";

        if (File.Exists(SaveFilePath))
        {
            Debug.Log("セーブファイルあるよ");
        }
        else
        {
            Debug.Log("なかったからつくるね");
            File.WriteAllText(SaveFilePath, "{\"Works\":[]}");
        }
    }
}
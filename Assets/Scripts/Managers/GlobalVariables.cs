using UnityEngine;
using System.IO;

public class GlobalVariables : MonoBehaviour
{
    public static GameObject CurrentWork;
    public static string SaveFilePath;

    private void Awake()
    {
        SaveFilePath = Application.persistentDataPath + "/SaveFile.json";

        if (!File.Exists(filePath) || string.IsNullOrEmpty(File.ReadAllText(filePath)))
        {
            File.WriteAllText(filePath, "{\"works\":[]}");
        }
        
        LoadController test = new LoadController();
        test.LoadWorks();
    }
}
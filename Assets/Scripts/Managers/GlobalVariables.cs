using UnityEngine;
using System.IO;

public class GlobalVariables : MonoBehaviour
{
    public static GameObject CurrentWork;
    public static string SaveFilePath;
    public LoadController loadController;

    private void Awake()
    {
        SaveFilePath = Application.persistentDataPath + "/SaveFile.json";

        if (!File.Exists(SaveFilePath) || string.IsNullOrEmpty(File.ReadAllText(SaveFilePath)))
        {
            File.WriteAllText(SaveFilePath, "{\"works\":[]}");
        }
        
        loadController.LoadWorks();
    }
}
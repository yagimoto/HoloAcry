using UnityEngine;
using System.IO;

public class LoadController : MonoBehaviour
{
    public void LoadWorks()
    {
        string WorksData = File.ReadAllText(GlobalVariables.SaveFilePath);
        Model LoadedData = JsonUtility.FromJson<Model>(WorksData);

        Debug.Log(LoadedData);

        Debug.Log(LoadedData.works.Count);
    }
}
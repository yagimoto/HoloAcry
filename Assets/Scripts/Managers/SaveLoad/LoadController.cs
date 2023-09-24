using UnityEngine;
using System.IO;

public class LoadController : MonoBehaviour
{
    public GameObject WorkSpace;

    public void LoadWorks()
    {
        string WorksData = File.ReadAllText(GlobalVariables.SaveFilePath);
        Model LoadedData = JsonUtility.FromJson<Model>(WorksData);

        foreach (var work in LoadedData.works)
        {
            Instantiate(WorkSpace); //
        }
    }
}
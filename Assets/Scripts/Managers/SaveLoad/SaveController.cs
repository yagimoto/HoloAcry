using UnityEngine;

public class SaveController : MonoBehaviour
{
    public void SaveElements()
    {
        foreach (Transform child in GlobalVariables.CurrentWork.transform)
        {
            GameObject Element = child.gameObject;
            Debug.Log("Elementの名前 " + Element.transform.name);


        }
    }
}
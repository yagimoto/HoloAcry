using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    public void SaveElements()
    {
        Work WorkData = new Work(); // 一つの作品のデータを格納するクラス

        // 作品内のすべてのオブジェクトを格納
        StoreElementData(GlobalVariables.CurrentWork, WorkData);

        Debug.Log(JsonUtility.ToJson(WorkData));
    }

    // 格納したいWork、格納先を引数として作品内のすべてのオブジェクトを格納する関数
    private void StoreElementData(GameObject WorkToSave, Work WorkData)
    {
        // 作品名を格納
        WorkData.work_name = WorkToSave.transform.name;

        // WorkDataクラス内のelementsを初期化
        WorkData.elements = new List<Element>();
        
        // 作品内のすべてのオブジェクトのデータを格納
        foreach (Transform child in WorkToSave.transform)
        {
            GameObject childObject = child.gameObject;
            Debug.Log("Elementの名前 " + childObject.transform.name);

            Color ElementColor = childObject.GetComponent<Renderer>().material.color;

            Element elementData = new Element
            {
                name = childObject.transform.name,
                scale = childObject.transform.localScale,
                position = childObject.transform.localPosition,
                color_R = ElementColor.r,
                color_G = ElementColor.g,
                color_B = ElementColor.b,
                color_A = ElementColor.a,
                rotate = childObject.transform.localEulerAngles
            };

            WorkData.elements.Add(elementData);
        }
    }
}
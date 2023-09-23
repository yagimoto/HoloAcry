using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{
    public void SaveElements()
    {
        Model SaveData = new Model(); // すべての作品のデータを格納するクラス
        SaveData.works = new List<Work>(); // SaveDataクラス内のworksを初期化

        Work WorkData = new Work(); // 一つの作品のデータを格納するクラス

        // 作品名を格納
        WorkData.work_name = GlobalVariables.CurrentWork.transform.name;
        // 作品内のすべてのオブジェクトのデータを格納
        foreach (Transform child in GlobalVariables.CurrentWork.transform)
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
        }
    }
}
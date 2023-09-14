using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsNameList : MonoBehaviour
{
    public GameObject ElementName; // 生成するPrefab
    public float Spacing = 100.0f; // Prefabの間隔

    public static List<GameObject> ElementNameList = new List<GameObject>(); // 作品内のすべてのPrefabを格納するリスト
    public GameObject prefabToDelete; // 消したいPrefab

    public void CreateComponent()
    {
        // Prefabを生成
        GameObject NewElementName = Instantiate(ElementName, this.transform);

        // 生成されたPrefabの位置を設定

        float xPos = (int)(ElementNameList.Count / 2) * 105;
        float yPos = ElementNameList.Count % 2 == 0 ? -10.0f : -150.0f;

        NewElementName.transform.localPosition = new Vector3(xPos, yPos, 0.0f);

        // 生成したPrefabをリストに追加
        ElementNameList.Add(NewElementName);
    }

    public void DestroyElementName()
    {
        // Prefabを削除
        Destroy(prefabToDelete);

        // PrefabをListから削除
        ElementNameList.Remove(prefabToDelete);

        // Prefabの位置をUpdate
        UpdatePrefabPositions();
    }

    void UpdatePrefabPositions()
    {
        for (int i = 0; i < ElementNameList.Count; i++)
        {
            float xPosition = (int)(i / 2) * 105;
            float yPosition = (i % 2 == 0) ? -10 : -150;

            ElementNameList[i].transform.localPosition = new Vector3(xPosition, yPosition, 0f);
        }
    }
}

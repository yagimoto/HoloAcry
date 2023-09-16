using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public GameObject ElementName; // 生成するPrefab
    public GameObject prefabToDelete; // 消したいPrefab

    public void CreateElementsName()
    {
        // Prefabを生成
        GameObject NewElementName = Instantiate(ElementName, this.transform);
    }

    public void DestroyElementName()
    {
        // Prefabを削除
        Destroy(prefabToDelete);
    }

}

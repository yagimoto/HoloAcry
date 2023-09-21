using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Element : MonoBehaviour
{
    public GameObject ElementPrefab;  // 生成するElementのPrefab
    public GameObject ElementName; // ElementNameのPrefab
    public GameObject prefabToDelete; // 消したいElement
    private int i = 0;

    public void CreateElement()
    {

        // Elementを生成
        GameObject NewElement = Instantiate(ElementPrefab);
        GameObject NewElementName = Instantiate(ElementName, this.transform);

        // 名前の変更
        NewElementName.transform.name = i.ToString();
        NewElement.transform.name = i.ToString();
        ElementName name = NewElementName.GetComponent<ElementName>();

        Debug.Log("Elementの名前 " + NewElement.transform.name);

        name.ChangeElementName(i.ToString());

        i++;

    }

    public void DestroyElementName()
    {
        // Prefabを削除
        Destroy(prefabToDelete);
    }
}

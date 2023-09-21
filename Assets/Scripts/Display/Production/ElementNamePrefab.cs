using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElementNamePrefab : MonoBehaviour
{
    public void ChangeElementNameText(string NewName)
    {
        // 子オブジェクトのTextを取得
        GameObject ElementNameText = this.transform.GetChild(0).gameObject;
        // Textのコンポーネントを取得
        TextMeshProUGUI TextStr = ElementNameText.GetComponent<TextMeshProUGUI>();
        // 表示名の変更
        TextStr.text = NewName;
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
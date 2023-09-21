using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElementName : MonoBehaviour
{
    public void ChangeElementName(string NewName)
    {
        GameObject ElementNameText = this.transform.GetChild(0).gameObject;

        TextMeshProUGUI TextStr = ElementNameText.GetComponent<TextMeshProUGUI>();

        TextStr.text = NewName;
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
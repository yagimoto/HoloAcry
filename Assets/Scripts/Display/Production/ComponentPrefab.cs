using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentPrefab : MonoBehaviour
{
    public GameObject component;

    public void CreateComponent()
    {
        // 生成される回数ごとに位置を変化させる必要がある
        
        Instantiate (component, new Vector3(340, 830, 0), Quaternion.identity, this.transform);
    }

    public void DestroyComponent()
    {
        Destroy(this.gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentPrefab : MonoBehaviour
{
    public GameObject component;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateComponent()
    {
        Instantiate (component, new Vector3(340, 830, 0), Quaternion.identity, this.transform);
    }

}

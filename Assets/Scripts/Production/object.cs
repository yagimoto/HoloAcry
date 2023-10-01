using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class @object : MonoBehaviour, IPointerClickHandler
{

    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        ProductionManager.selectedGameObjects.Add(gameObject);
        Debug.Log("クリック");
    }

    void SetMatColor(MeshRenderer mesh,Color col )
    {
        mesh.material.color = col; //meshのmaterialの色を変える
    }

}

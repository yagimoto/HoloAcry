using UnityEngine;

public class WorksObject : MonoBehaviour
{
    public GameObject WorkSpace;
    private float x = 0;
    private float y = 125;
    public void CreateWork()
    {
        GameObject NewWork = Instantiate(WorkSpace, this.transform);

        x = ( this.transform.childCount % 2 ) == 0 ? 125.0f : 0.0f;
        y = ( this.transform.childCount % 2 ) == 0 ? y : y - 125.0f;
        
        NewWork.transform.localPosition = new Vector3(x , y, 0.0f);
        NewWork.transform.name = "Work" + this.transform.childCount.ToString();

        GameManager.CurrentWork = NewWork;
    }
}
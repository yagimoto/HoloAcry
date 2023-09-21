using UnityEngine;

public class WorksObject : MonoBehaviour
{
    public GameObject WorkSpace;
    public void CreateWork()
    {
        GameObject NewWork = Instantiate(WorkSpace, this.transform);
        NewWork.transform.name = "Work" + this.transform.childCount.ToString();

        GameManager.CurrentWork = NewWork;
    }
}
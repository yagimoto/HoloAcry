using UnityEngine;

public class WorksObject : MonoBehaviour
{
    public GameObject WorkSpace;
    public void CreateWork()
    {
        GameManager.CurrentWork = Instantiate(WorkSpace, this.transform);
    }
}
using UnityEngine;

public class WorksObject : MonoBehaviour
{
    public GameObject WorkSpace;
    public void CreateWork()
    {
        Instantiate(WorkSpace, this.transform);
    }
}
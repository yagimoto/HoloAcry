using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Element
{
    public string name;
    public Vector3 scale;
    public Vector3 position;
    public float color_R;
    public float color_G;
    public float color_B;
    public float color_A;
    public Vector3 rotate;
}

[System.Serializable]
public class Work
{
    public string work_name;
    public List<Element> elements;
}

[System.Serializable]
public class Model
{
    public List<Work> works;
}

using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
// Elementのデータを格納するクラス
public class Element
{
    public string name;       // Elementの名前を格納
    public Vector3 scale;     // ElementのlocalScaleを格納
    public Vector3 position;  // ElementのlocalPositionを格納
    public float color_R;     // Elementの色のR値を格納
    public float color_G;     // Elementの色のG値を格納
    public float color_B;     // Elementの色のB値を格納
    public float color_A;     // Elementの色のA値を格納
    public Vector3 rotate;    // ElementのlocalEulerAnglesを格納
}

[System.Serializable]
// Workの中のすべてのElementと作品名を格納するクラス
public class Work
{
    public string work_name;       // 作品の名前を格納
    public List<Element> elements; // 作品内のすべてのElementを格納
}

[System.Serializable]
// プロジェクト内のすべてのWorkを格納するクラス
public class Model
{
    public List<Work> works;        // すべての作品を格納
}

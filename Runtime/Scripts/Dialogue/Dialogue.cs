using UnityEngine;

[System.Serializable]
//Dialogue can be set in the inspector
public class Dialogue
{
    public string name;


    [TextArea(3, 10)]
    public string[] sentences;
}


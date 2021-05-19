using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Saves the lines in a struct so each Line has a character and text
[System.Serializable]
public struct Line
{
    public NPC character;
    [TextArea(2,5)] //Text holding multiple lines 
    public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversation/Scene2", order = 0)]
public class Conversation : ScriptableObject
{
public NPC speaker1;
public NPC speaker2;
public Line[] lines;
}

using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string characterName;
    public Sprite characterPortrait;
    public Sprite background;
    [TextArea(3, 10)]
    public string[] sentences;
}

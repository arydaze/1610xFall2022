using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class IntData : ScriptableObject
{
    public int value;

    text = new txt();
    text = string("Hello World");

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}

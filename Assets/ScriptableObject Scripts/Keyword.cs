using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/Keyword")]
public class Keyword : ScriptableObject
{
    public string Name = "Keyword";
    public bool HasIcon = true;
    public Sprite Icon;

    [TextArea]
    public string ReminderText = "Reminder Text";
}

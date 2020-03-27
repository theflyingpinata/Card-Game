using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo : ScriptableObject
{
    public string Name;

    public List<Keyword> Keywords;
    public Region Region;

    public int ManaCost;
    public int Attack;
    public int Health;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/Card Info")]
public class CardInfo : ScriptableObject
{
    public string Name = "Card";
    [TextArea]
    public string Text = "Does a thing";

    public Rarity Rarity;

    public string ID;

    public Sprite Art;

    public List<Keyword> Keywords;
    public Region Region;

    public int ManaCost = 1;
}

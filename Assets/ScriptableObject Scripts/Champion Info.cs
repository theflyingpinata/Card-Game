using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card/Champion Info")]
public class ChampionInfo : FollowerInfo
{
    public string LevelUpText = "Eat the duck";
    public LevelUpCondition LevelUpCondition;
}

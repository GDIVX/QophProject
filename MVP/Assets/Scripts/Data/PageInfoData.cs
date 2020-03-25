using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PageData", menuName = "ScriptableObjects / Adventurer's Handbook / PageData", order = 2)]
public class PageInfoData : ScriptableObject
{
    public string headline;
    public string oneLiner;
    public string shortDescription;
    public Sprite illustration;
    public string tacticalInfo;
    public string loreOneLiner;
    public int dangerScale;
    public int HP;
    public int physicalDamage;
    public int nonPhysicalDamage;

}

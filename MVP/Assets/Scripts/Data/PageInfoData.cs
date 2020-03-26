using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "PageData", menuName = "ScriptableObjects / Adventurer's Handbook / PageData", order = 2)]
[System.Serializable]
public class PageInfoData : ScriptableObject
{
    public PageController observer { set; protected get; }

    public string headline { set { _headline = value; observer.UpdatePage(); } get { return _headline; } }
    public string SubTitle { set { _SubTitle = value; observer.UpdatePage(); } get { return _SubTitle; } }
    public string description { set { _description = value; observer.UpdatePage(); } get { return _description; } }
    public string lore { set { _lore = value; observer.UpdatePage(); } get { return _lore; } }
    public string tacticalInfo { set { _tacticalInfo = value; observer.UpdatePage(); } get { return _tacticalInfo; } }
    public Sprite illustration { set { _illustration = value; observer.UpdatePage(); } get { return _illustration; } }
    public int dangerScale { set { _dangerScale = value; observer.UpdatePage(); } get { return _dangerScale; } }
    public int health { set { _health = value; observer.UpdatePage(); } get { return _health; } }
    public int physicalDamage { set { _physicalDamage = value; observer.UpdatePage(); } get { return _physicalDamage; } }
    public int magicalDamage { set { _magicalDamage = value; observer.UpdatePage(); } get { return _magicalDamage; } }


    string _headline;
     string _SubTitle;
     string _description;
     string _lore;
     string _tacticalInfo;

     Sprite _illustration;

     int _dangerScale;
     int _health;
     int _physicalDamage;
     int _magicalDamage;
}

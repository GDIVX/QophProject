using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class PageFactory 
{
   public static PageInfoData Blank()
    {
        PageInfoData res = new PageInfoData();
        res.dangerScale = -1;
        res.description = $"Unknown";
        res.headline = $"Unknown Monster";
        res.health = -1;
        res.illustration = null; // TODO add a black sprite image
        res.lore = "Unknown";
        res.magicalDamage = -1;
        res.physicalDamage = -1;
        res.SubTitle = "One of the mystories of the world";
        res.tacticalInfo = "Better be careful, you don't know what trickery this monster may hide.";
        return res;
    }

    public static string GetTextFromInt(int a)
    {
        if(a == -1) { return "Unknown"; }
        else { return a.ToString(); }
    }

    public static PageView ViewFromPage(PageInfoData page)
    {
        PageView res = new PageView();
        res.SubTitle.text = page.SubTitle;
        res.tacticalInfo.text = page.tacticalInfo;
        res.dangerScale.text = GetTextFromInt(page.dangerScale);
        res.description.text = page.description;
        res.headline.text = page.headline;
        res.health.text = GetTextFromInt(page.health);
        res.illustration.sprite = page.illustration;
        res.lore.text = page.lore;
        res.magicalDamage.text = GetTextFromInt(page.magicalDamage);
        res.physicalDamage.text = GetTextFromInt(page.physicalDamage);
        return res;
    }
}

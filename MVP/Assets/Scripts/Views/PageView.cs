using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageView : MonoBehaviour
{
    [SerializeField]
    public PageInfoData page { get; set; }

    [SerializeField]
    public Text headline { get; set; }
    [SerializeField]
    public Text oneLiner { get; set; }
    [SerializeField]
    public Text shortDescription { get; set; }

    [SerializeField]
    public Image illustration { get; set; }

    [SerializeField]
    public Text tacticalInfo { get; set; }
    [SerializeField]
    public Text loreOneLiner { get; set; }
    [SerializeField]
    public Text dangerScale { get; set; }
    [SerializeField]
    public Text HP { get; set; }
    [SerializeField]
    public Text physicalDamage { get; set; }
    [SerializeField]
    public Text nonPhysicalDamage { get; set; }

    private void Start()
    {
        headline.text = page.headline;
        oneLiner.text = page.oneLiner;
        shortDescription.text = page.shortDescription;

        illustration.sprite = page.illustration;

        tacticalInfo.text = page.tacticalInfo;
        loreOneLiner.text = page.loreOneLiner;
        //dangerScale.text = page.dangerScale;
        HP.text = page.HP.ToString();
        physicalDamage.text = page.physicalDamage.ToString();
        nonPhysicalDamage.text = page.nonPhysicalDamage.ToString();

    }
}

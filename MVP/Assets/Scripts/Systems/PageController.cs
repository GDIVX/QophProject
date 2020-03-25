using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PageController : MonoBehaviour
{
    [SerializeField]
    GameObject AdventurerBook;
    bool isActive = false;

    PageInfoData pageInfoData;
    PageInfoRunTime pageInfoRunTime;
    PageView pageView;

    public Action OnUpdatePage;

    private void Awake()
    {
        pageInfoData = ScriptableObject.CreateInstance<PageInfoData>();
        pageInfoRunTime = new PageInfoRunTime();
        pageView = gameObject.GetComponent<PageView>();
    }
    void Start()
    {
        UpdatePage();
        pageInfoRunTime.headline = pageInfoData.headline;
        pageInfoRunTime.oneLiner = pageInfoData.oneLiner;
        pageInfoRunTime.shortDescription = pageInfoData.shortDescription;
        pageInfoRunTime.illustration = pageInfoData.illustration;
        pageInfoRunTime.tacticalInfo = pageInfoData.tacticalInfo;
        pageInfoRunTime.loreOneLiner = pageInfoData.loreOneLiner;
        pageInfoRunTime.dangerScale = pageInfoData.dangerScale;
        pageInfoRunTime.HP = pageInfoData.HP;
        pageInfoRunTime.physicalDamage = pageInfoData.physicalDamage;
        pageInfoRunTime.nonPhysicalDamage = pageInfoData.nonPhysicalDamage;
    }

    void UpdatePage()
    {
        GetNewPage("PageDataTest");
        pageView.headline.text = pageInfoRunTime.headline;
        pageView.oneLiner.text = pageInfoRunTime.oneLiner;
        pageView.shortDescription.text = pageInfoRunTime.shortDescription;
        pageView.illustration.sprite = pageInfoRunTime.illustration;
        pageView.tacticalInfo.text = pageInfoRunTime.tacticalInfo;
        pageView.loreOneLiner.text = pageInfoRunTime.loreOneLiner;
        pageView.dangerScale.text = pageInfoRunTime.dangerScale.ToString();
        pageView.HP.text = pageInfoRunTime.HP.ToString();
        pageView.physicalDamage.text = pageInfoRunTime.physicalDamage.ToString();
        pageView.nonPhysicalDamage.text = pageInfoRunTime.nonPhysicalDamage.ToString();
    }
    public void OnClick()
    {
        if (isActive)
        {
            AdventurerBook.SetActive(false);
            isActive = false;
        }
        else
        {
            AdventurerBook.SetActive(true);
            isActive = true;
        }
    }

    void GetNewPage(string pathPage)
    {
        pageInfoData = Resources.Load<PageInfoData>(pathPage);
        pageView.page = pageInfoData;
    }

}

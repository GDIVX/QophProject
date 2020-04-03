using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(PageView))]
public class PageController : MonoBehaviour
{
    public PageInfoData data;
    PageView View;

    private void Awake() 
    {
        View = gameObject.GetComponent<PageView>();
        if (data == null)
        {
            data = PageFactory.Blank();
        }
        data.observer = this;
    }

    void Start()
    {
        UpdatePage();
    }

    public void UpdatePage()
    {
        View = PageFactory.ViewFromPage(data);
    }
}

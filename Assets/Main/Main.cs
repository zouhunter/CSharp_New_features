﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField]
    private Text m_title;
    private string[] baseNames = new string[] {
        "c#4.0",
        "c#5.0",
        "c#6.0",
    };
    [SerializeField]
    private Cs_Holder holder;
    [SerializeField]
    private Button last;
    [SerializeField]
    private Button next;
    [SerializeField]
    private Text m_log;
    private int currentIndex;

    private void Awake()
    {
        last.onClick.AddListener(Last);
        next.onClick.AddListener(Next);
        holder.onLog = Log;
    }
    private void OnEnable()
    {
        currentIndex = 0;
        OpenCurrentPanel();
    }

    private void Next()
    {
        if (++currentIndex > baseNames.Length - 1){
            currentIndex = 0;
        }
        OpenCurrentPanel();
    }

    private void Last()
    {
        if (--currentIndex < 0){
            currentIndex = baseNames.Length - 1;
        }
        OpenCurrentPanel();
    }

    private void OpenCurrentPanel()
    {
        if(currentIndex >= 0 && currentIndex < baseNames.Length)
        {
            holder.Switch(baseNames[currentIndex]);
            m_title.text = baseNames[currentIndex];
            m_log.text = "";
        }
    }
    private void Log(object info)
    {
        m_log.text += info?.ToString() + "\n";
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample4_01 : ISample
{
    public UnityAction<string> onLog { get; set; }
    public string titleName
    {
        get
        {
            return "Sample4_01";
        }
    }

    public void Execute()
    {
        Debug.Log("Execute");
        onLog("Execute");
    }
}

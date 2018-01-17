using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample5_01 : ISample
{
    public UnityAction<object> Log { get; set; }
    public string titleName
    {
        get
        {
            return "";
        }
    }

    public void Execute()
    {

    }
}

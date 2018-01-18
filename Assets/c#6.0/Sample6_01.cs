using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample6_01 : ISample
{
    public UnityAction<object> Log { get; set; }

    public string titleName
    {
        get
        {
            return "字符串插值";
        }
    }

    public void Execute()
    {
        var Name = "Jack";
        var results = $"Hello {Name}";
        Log(results);
    }
}

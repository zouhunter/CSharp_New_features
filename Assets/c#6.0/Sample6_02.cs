using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample6_02 : ISample
{
    public UnityAction<object> Log { get; set; }

    public string titleName
    {
        get
        {
            return "字符串插代码";
        }
    }

    public void Execute()
    {
        Log($"Jack is saying { SayHello() }");
    }

    private object SayHello()
    {
        return "Hellow";
    }
}

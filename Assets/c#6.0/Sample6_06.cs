using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
public class Sample6_06 : ISample
{
    private static string SayHello() => "Hello World";
    private static string JackSayHello() => $"Jack {SayHello()}";

    public UnityAction<object> Log { get; set; }
    public string titleName
    {
        get
        {
            return "表达式方法体";
        }
    }
    public void Execute()
    {
        Log(SayHello());
        Log(JackSayHello());
    }
}

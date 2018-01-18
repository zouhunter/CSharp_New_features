using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using static System.Math;

public class Sample6_10 : ISample
{
    public UnityAction<object> Log { get; set; }
   
    public string titleName
    {
        get
        {
            return "using 静态类的方法可以使用 static using";
        }
    }
    public void Execute()
    {
        Log(Log10(5) + PI);
    }
}

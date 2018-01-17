using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample4_01 : ISample
{
    public UnityAction<object> Log { get; set; }
    public string titleName
    {
        get
        {
            return "dynamic";
        }
    }

    public void Execute()
    {
        dynamic calc = new Calculator();
        int sum = calc.Add(10, 20);
        Log(sum.ToString());
    }

    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
}

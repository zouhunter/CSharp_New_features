using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
public class Sample6_07 : ISample
{
    
    public UnityAction<object> Log { get; set; }
    public int Age { get; set; } = 100;
    public string titleName
    {
        get
        {
            return "自动属性初始化器";
        }
    }
    public void Execute()
    {
        Log(Age);
    }
}

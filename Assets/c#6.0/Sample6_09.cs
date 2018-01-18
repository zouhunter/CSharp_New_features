using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
public class Sample6_09 : ISample
{
    
    public UnityAction<object> Log { get; set; }
   
    public string titleName
    {
        get
        {
            return "Index 初始化器";
        }
    }
    public void Execute()
    {
        var names = new Dictionary<int,string>
        {
            [1] = "Jack",
            [2] = "Alex",
            [3] = "Eric",
            [4] = "Jo"
        };
        foreach (var item in names)
        {
            Log($"{item.Key} = {item.Value}");
        }
    }
}

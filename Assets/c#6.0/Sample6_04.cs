using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Sample6_04 : ISample
{
    public UnityAction<object> Log { get; set; }
    private User user;
    public string titleName
    {
        get
        {
            return "nameof";
        }
    }

    public void Execute()
    {
        Log(nameof(User.Name)); //  output: Name
        Log(nameof(System.Linq)); // output: Linq
        Log(nameof(Array)); // output: List
    }
    public class User
    {
        public static string Name;
    }
}

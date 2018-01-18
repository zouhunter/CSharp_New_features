using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample6_03 : ISample
{
    public UnityAction<object> Log { get; set; }
    private User user;
    public string titleName
    {
        get
        {
            return "空操作符";
        }
    }

    public void Execute()
    {
        Log(user?.Name);
        user = new User();
        Log(user?.Name);
    }
    public class User
    {
        public string Name;
    }
  
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
public class Sample6_08 : ISample
{
    
    public UnityAction<object> Log { get; set; }
    public string titleName
    {
        get
        {
            return "异常过滤器";
        }
    }
    public void Execute()
    {
        try
        {
            throw new ArgumentException("Age");
        }
        catch (ArgumentException argumentException) when (argumentException.Message.Equals("Name"))
        {
            throw new ArgumentException("Name Exception");

        }

        catch (ArgumentException argumentException) when (argumentException.Message.Equals("Age"))
        {
            throw new Exception("not handle");

        }
        catch (Exception e)
        {

            throw e;
        }
    }
}

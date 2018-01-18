using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
public class Sample6_05 : ISample
{
    public UnityAction<object> Log { get; set; }
    public string titleName
    {
        get
        {
            return "在Catch和Finally里使用Await";
        }
    }
    public void Execute()
    {
        Execute0();
    }
    public async void Execute0()
    {
        Resource res = null;
        try
        {
            res = await Resource.OpenAsync(); // You could always do this.  
            Log("try");
        }
        catch(Exception e)
        {
            await Resource.LogAsync(res, e); // Now you can do this … 
            Log("catch" + e);
        }
        finally
        {
            if (res != null) await res.CloseAsync(); // … and this.
            Log("finally");
        }
    }

    public class Resource
    {
        public static string Name;

        internal static Task LogAsync(Resource res, object e)
        {
            throw new NotImplementedException();
        }

        internal static Task<Resource> OpenAsync()
        {
             Task.Delay(10);
            return new Task<Resource>(()=> { return new Resource(); });// new Resource();
        }

        internal Task CloseAsync()
        {
            return Task.Delay(1);
        }
    }
}

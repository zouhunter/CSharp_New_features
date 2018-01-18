using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;
using UnityEngine.UI;
using System.Net;
using System.Threading;
public class Sample5_01 : ISample
{
    public UnityAction<object> Log { get; set; }
    private Text text;
    public string titleName
    {
        get
        {
            return "async await";
        }
    }

    public void Execute()
    {
        var canvas = GameObject.FindObjectOfType<Canvas>();
        text = new GameObject("test", typeof(Text)).GetComponent<Text>();
        text.transform.SetParent(canvas.transform,false);
        Log(string.Format("Current Thread Id :{0}", Thread.CurrentThread.ManagedThreadId));

        OnTest1();
    }

    private async void OnTest1()
    {
        Log("OnTestA");
        long back = await AccessWebAsync();
        Log(back);
    }

    private async Task<long> AccessWebAsync()
    {
        // Delay 方法来自于.net 4.5
        await Task.Delay(1000);  // 返回值前面加 async 之后，方法里面就可以用await了
        Log(string.Format( "Current Thread Id :{0}" , Thread.CurrentThread.ManagedThreadId));
        Log("In antoher thread.....");
        text.text = "jump";
        return 10;
    }
    //private async Task<long> AccessWebAsync()
    //{
    //    Thread.Sleep(5);
    //    return 2;
    //}

}
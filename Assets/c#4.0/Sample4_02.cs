using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sample4_02 : ISample
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
        dynamic a = 1;
        Log(a);
        Log(a.GetType());
        a = "\n a";
        Log(a);
        Log(a.GetType());
    }


    //public abstract class DynamicObject : IDynamicObject
    //{
    //    public virtual object GetMember(GetMemberBinder info);
    //    public virtual object SetMember(SetMemberBinder info, object value);
    //    public virtual object DeleteMember(DeleteMemberBinder info); public virtual object UnaryOperation(UnaryOperationBinder info);
    //    public virtual object BinaryOperation(BinaryOperationBinder info, object arg);
    //    public virtual object Convert(ConvertBinder info); public virtual object Invoke(InvokeBinder info, object[] args);
    //    public virtual object InvokeMember(InvokeMemberBinder info, object[] args);
    //    public virtual object CreateInstance(CreateInstanceBinder info, object[] args); public virtual object GetIndex(GetIndexBinder info, object[] indices);
    //    public virtual object SetIndex(SetIndexBinder info, object[] indices, object value);
    //    public virtual object DeleteIndex(DeleteIndexBinder info, object[] indices); public MetaObject IDynamicObject.GetMetaObject();
    //}


}

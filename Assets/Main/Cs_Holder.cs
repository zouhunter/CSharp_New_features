using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cs_Holder : MonoBehaviour
{
    [SerializeField]
    private Button prefab;
    internal Action<object> onLog { get; set; }
    private Dictionary<string, List<ISample>> sampleDic = new Dictionary<string, List<ISample>>();
    private List<Button> created = new List<Button>();

    public void Switch(string baseName)
    {
        CleanCreated();

        if (!sampleDic.ContainsKey(baseName))
        {
            var samples = LoadSamples(baseName);
            if(samples != null){
                sampleDic[baseName] = samples;
            }
        }
        SwitchSampleInternal(sampleDic[baseName]);
    }

    private void SwitchSampleInternal(List<ISample> samples)
    {
        foreach (var item in samples)
        {
            var obj = Instantiate(prefab);
            obj.gameObject.transform.SetParent(transform,false);
            obj.GetComponentInChildren<Text>().text = item.titleName;
            obj.onClick.AddListener(item.Execute);
            created.Add(obj);
        }
    }

    private List<ISample> LoadSamples(string baseName)
    {
        var types = this.GetType().Assembly.GetTypes();
        var samples = new List<ISample>();
        foreach (var type in types)
        {
            if(typeof(ISample).IsAssignableFrom(type) && type.Name.StartsWith(baseName)){
                var item = System.Activator.CreateInstance(type) as ISample;
                item.Log = Log;
                samples.Add(item);
            }
        }
        return samples;
    }

    private void CleanCreated()
    {
        foreach (var item in created){
            Destroy(item.gameObject);
        }
        created.Clear();
    }

    protected void Log(object info)
    {
        if(onLog != null)
        {
            onLog.Invoke(info);
        }
    }
}

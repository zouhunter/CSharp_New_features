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
            if (samples != null)
            {
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
            obj.gameObject.transform.SetParent(transform, false);
            obj.GetComponentInChildren<Text>().text = item.titleName;
            obj.onClick.AddListener(item.Execute);
            created.Add(obj);
        }
    }

    private List<ISample> LoadSamples(string baseName)
    {
        var list = new List<ISample>();
        if (baseName == "c#4.0")
        {
            InitSample<Sample4_01>(list);
            InitSample<Sample4_02>(list);
        }
        else if (baseName == "c#5.0")
        {
            InitSample<Sample5_01>(list);
        }
        else if (baseName == "c#6.0")
        {
            InitSample<Sample6_01>(list);
            InitSample<Sample6_02>(list);
            InitSample<Sample6_03>(list);
            InitSample<Sample6_04>(list);
            InitSample<Sample6_05>(list);
            InitSample<Sample6_06>(list);
            InitSample<Sample6_07>(list);
            InitSample<Sample6_08>(list);
            InitSample<Sample6_09>(list);
            InitSample<Sample6_10>(list);

        }
        return list;
    }
    private void InitSample<T>(List<ISample> list) where T : ISample, new()
    {
        var sample = new T();
        sample.Log = Log;
        list.Add(sample);
    }

    private void CleanCreated()
    {
        foreach (var item in created)
        {
            Destroy(item.gameObject);
        }
        created.Clear();
    }

    protected void Log(object info)
    {
        if (onLog != null)
        {
            onLog.Invoke(info);
        }
    }
}

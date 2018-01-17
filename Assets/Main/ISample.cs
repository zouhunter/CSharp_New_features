using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface ISample {
    string titleName { get; }
    void Execute();
    UnityAction<string> onLog { get; set; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface ISample {
    string titleName { get; }
    void Execute();
    UnityAction<object> Log { get; set; }
}

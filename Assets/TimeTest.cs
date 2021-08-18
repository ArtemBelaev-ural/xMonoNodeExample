using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class TimeTest : MonoBehaviour
{
    [SerializeField]
    private FlowNodeGraph graph;

    [SerializeField]
    private bool WaitUntil = false;

    [SerializeField]
    private bool WaitWhile = true;

    [SerializeField]
    private bool WaitForFlow = false;

    [SerializeField]
    private bool WaitForNextFrame = false;

    void Update()
    {
        if (graph == null)
        {
            return;
        }

        graph.UpdateInputParameters(new Dictionary<string, object>()
        {
            { nameof(WaitUntil), WaitUntil },
            { nameof(WaitWhile), WaitWhile },
            { nameof(WaitForFlow), WaitForFlow },
            { nameof(WaitForNextFrame), WaitForNextFrame}
        });
        if (WaitForNextFrame)
        {
            WaitForNextFrame = false;
        }
    }
}

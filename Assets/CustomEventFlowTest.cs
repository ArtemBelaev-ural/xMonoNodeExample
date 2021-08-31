using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class CustomEventFlowTest : MonoBehaviour
{
    [SerializeField]
    FlowNodeGraph graph;

    [SerializeField]
    private bool start = false;

    private bool started = false;

    [SerializeField]
    private bool customStart = false;

    private bool customStarted = false;

    // Update is called once per frame
    void Update()
    {
        if (start && !started)
        {
            Go();
            started = true;
        }

        if (!start && started)
        {
            started = false;
        }

        if (customStart && !customStarted)
        {
            GoCustom();
            customStarted = true;
        }

        if (!customStart && customStarted)
        {
            customStarted = false;
        }

    }

    private void Go()
    {
        graph.Flow(OnFlowEnd, "state");
    }

    private void OnFlowEnd(string state)
    {
        Debug.Log("OnFlowEnd: " + state);
    }

    private void GoCustom()
    {
        graph.CustomEvent("CustomEvent");
    }
}

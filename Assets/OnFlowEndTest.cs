using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class OnFlowEndTest : MonoBehaviour
{
    [SerializeField]
    FlowNodeGraph graph;

    [SerializeField]
    private bool start = false;

    private bool started = false;

    // Update is called once per frame
    void Update()
    {
        if (start && !started)
        {
            Start();
            started = true;
        }

        if (!start && started)
        {
            started = false;
        }

    }

    private void Start()
    {
        graph.Flow(OnFlowEnd, "state");
    }

    private void OnFlowEnd(string state)
    {
        Debug.Log("OnFlowEnd: " + state);
    }
}

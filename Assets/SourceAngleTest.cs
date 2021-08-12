using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class SourceAngleTest : MonoBehaviour
{
    [SerializeField]
    private FlowNodeGraph graph;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && graph != null)
        {
            graph.Flow();
        }
    }
}

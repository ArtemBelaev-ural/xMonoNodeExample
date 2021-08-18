using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class OutputParametersTest : MonoBehaviour
{
    [SerializeField]
    private FlowNodeGraph graph = null;

    // Start is called before the first frame update
    void Start()
    {
        graph = GetComponent<FlowNodeGraph>();
    }

    public void printOutputParameters()
    {
        Debug.Log("print Output Parameters:");

        graph.GetOutputParameters(out Dictionary<string, object> parameters);

        int counter = 0;

        foreach (var pair in parameters)
        {
            ++counter;
            Debug.LogFormat("{0}) {1}: {2}", counter, pair.Key, pair.Value);
        }
    }
}

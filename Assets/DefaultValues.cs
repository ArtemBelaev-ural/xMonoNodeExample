using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class DefaultValues : MonoBehaviour
{
    [SerializeField]
    private FlowNodeGraph graph;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        graph.GetOutputParameters(out Dictionary<string, object> parameters);
        Debug.LogFormat("input float: {0}, default float: {1}", parameters["float"], parameters["floatDefault"]);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

[ExecuteInEditMode]
public class FlowNodeGraphGetterTest : MonoBehaviour
{
    [SerializeField]
    private FlowNodeGraphGetter effect = new FlowNodeGraphGetter("Animation/XContainers/", "ui.main", "defile");
    
}

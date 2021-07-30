using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

[ExecuteInEditMode]
public class PlaySoundByMaterial : MonoBehaviour
{
    [SerializeField]
    private XSoundNodeGraph graph = null;
    [SerializeField]
    private PhysicMaterial material = null;

    private void OnEnable()
    {
        if (graph != null)
        {
            graph.Execute(material);
        }
    }
}

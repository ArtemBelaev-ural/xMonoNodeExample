using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

[ExecuteInEditMode]
public class SoundGetterTest : MonoBehaviour
{

    [SerializeField]
    private XSoundGetter sound = new XSoundGetter("Sounds/XContainers", "sounds.containers.main", "");

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

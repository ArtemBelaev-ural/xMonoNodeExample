using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

public class TestNamedParameters : MonoBehaviour
{

    [SerializeField]
    private XSoundNodeGraph sound = null;

    [SerializeField, Range(0f, 1f)]
    private float           volume = 0.8f;

    [SerializeField, Range(0.1f, 2f)]
    private float           pitch = 0.8f;

    [SerializeField]
    private bool            grounded = true;       


    private void Start()
    {
        if (gameObject.activeInHierarchy)
        {
            sound.Flow();
        }
    }

    private void OnDisable()
    {
        sound.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        sound.UpdateParameters(new Dictionary<string, object>
        {
            { nameof(volume), volume },
            { nameof(pitch),  pitch },
            { nameof(grounded), grounded}
        });
    }
}

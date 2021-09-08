using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XMonoNode;

[ExecuteInEditMode]
public class SoundGetterTest : MonoBehaviour
{
    [SerializeField]
    private XSoundGetter sound = new XSoundGetter("Sounds/XContainers/", "sounds.containers.main", "");

    [SerializeField]
    private Transform mesh;
    [SerializeField]
    private WheelCollider wheel;

    [SerializeField]
    private float motorTorque = 0.0f;
    
    [Header("Debug")]
    [SerializeField]
    private float rpm;
    [SerializeField]
    private float brakeTorcue;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = Mathf.Infinity;
    }

    private void FixedUpdate()
    {
        wheel.motorTorque = motorTorque;
        rpm = wheel.rpm;
        brakeTorcue = wheel.brakeTorque;
        


        wheel.GetWorldPose(out Vector3 pos, out Quaternion rot);
        mesh.localRotation = rot; //21;
    }
}

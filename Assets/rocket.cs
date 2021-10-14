using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody body;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float force = Input.GetAxis("force");
        float horizontal = Input.GetAxis("Horizontal");

        body.AddRelativeForce(Vector3.up * force * Time.fixedDeltaTime * 10);
        body.AddRelativeTorque(Vector3.forward * horizontal * Time.fixedDeltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [SerializeField]
    private Transform rotator = null;

    [SerializeField]
    private Transform camera = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 5);
            rotator.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * 5);
        }
        if (Input.GetMouseButton(1))
        {
            camera.Rotate(Vector3.up * Input.GetAxis("Mouse X") * 5, Space.World);
            camera.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * 5, Space.Self);
        }
        
    }
}

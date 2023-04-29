using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyObject : Object3D
{
    [SerializeField] private float jumpForce = 1;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            objectRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

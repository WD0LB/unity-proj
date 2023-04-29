using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3D : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    protected Rigidbody objectRb;

    void Start() {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
    }
    protected virtual void MoveHorizontal()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        objectRb.AddForce(Vector3.right * horizontalInput * speed);
    }
    protected virtual void MoveVertical()
    {
        float verticalInput = Input.GetAxis("Vertical");
        objectRb.AddForce(Vector3.forward * verticalInput * speed);
    }
}

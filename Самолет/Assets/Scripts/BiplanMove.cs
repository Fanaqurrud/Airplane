using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplanMove : MonoBehaviour
{
    public Rigidbody Rigidbody;

    public float ConstForceValue = 0.2f;
    public float ForceValue = 1f;
    public float TorqueValue = 0.15f;

    void FixedUpdate()
    {
        Rigidbody.AddForce(transform.forward * ConstForceValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody.AddForce(transform.forward * ForceValue, ForceMode.VelocityChange);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        Rigidbody.AddTorque(transform.right * TorqueValue * horizontalInput, ForceMode.VelocityChange);
    }
}

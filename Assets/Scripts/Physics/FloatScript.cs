using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FloatScript : MonoBehaviour
{
    [SerializeField]
    private float waterLevel = 0.0f;

    [SerializeField]
    private float floatThreshold = 2.0f;

    [SerializeField]
    private float waterDensity = 0.125f;

    [SerializeField]
    private float downForce = 4.0f;

    private float forceFactor;
    private Vector3 floatForce;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        forceFactor = 1.0f - ((transform.position.y - waterLevel) / floatThreshold);

        if (forceFactor > 0.0f)
        {
            //Check for the force the objects applies and add a force equal to that to the object upwards
            floatForce = -Physics.gravity * rb.mass * (forceFactor - rb.velocity.y * waterDensity);
            floatForce += new Vector3(0.0f, -downForce * rb.mass, 0.0f);
            rb.AddForceAtPosition(floatForce, transform.position);
        }
    }
}
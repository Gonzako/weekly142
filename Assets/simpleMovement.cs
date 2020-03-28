using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMovement : MonoBehaviour
{
    Rigidbody rb;
    public float maxVel = 2f;

    private Vector3 inputVect;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        inputVect.x = Input.GetAxis("Horizontal");
        inputVect.z = Input.GetAxis("Vertical");
        if(inputVect.magnitude > 0)
        {
            transform.rotation = Quaternion.AngleAxis(Vector3.Angle(transform.position, transform.position + inputVect), Vector3.up);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = inputVect.normalized * maxVel;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGidisi : MonoBehaviour
{
    public Rigidbody rb;

    public float karakterDikeyHizi=200f;
    public float karakterYatayHizi=50f;

    void FixedUpdate()
    {

        rb.AddForce(0, 0, karakterDikeyHizi * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(karakterYatayHizi * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-karakterYatayHizi * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}

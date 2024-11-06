using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phys : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 2, 0), ForceMode.Impulse);

        }
    }
}

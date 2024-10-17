using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptcube : MonoBehaviour
{
    float runSpeed = 25f;

    float turnAngle = 135f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += runSpeed * transform.forward * Time.deltaTime;
            transform.Rotate(Vector3.left, 0 * Time.deltaTime);
            transform.Rotate(Vector3.right, 0 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= runSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnAngle * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnAngle * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += runSpeed * transform.up * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= runSpeed * transform.up * Time.deltaTime;
        }
    }
}

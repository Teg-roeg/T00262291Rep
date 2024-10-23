using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptcube : MonoBehaviour
{
    Animator runAnim;

    float runSpeed = 5f;
    float walkSpeed = 1f;

    float turnAngle = 110f;

    // Start is called before the first frame update
    void Start()
    {
        runAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        runAnim.SetBool("run", false);
        runAnim.SetBool("walk", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += runSpeed * transform.forward * Time.deltaTime;
            // animation run true statement
            runAnim.SetBool("run", true);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += walkSpeed * transform.forward * Time.deltaTime;
            transform.position -= runSpeed * transform.forward * Time.deltaTime;
            // animation run true statement
            runAnim.SetBool("walk", true);
            runAnim.SetBool("run", false);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnAngle * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnAngle * Time.deltaTime);
        }
    }
}

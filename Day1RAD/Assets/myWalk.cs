using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myWalk : MonoBehaviour
{


    void Update()
    {

        float movement = Input.GetAxis("Vertical");
        movement *= Time.deltaTime;

        this.transform.Translate
        (Vector3.forward * movement);
    }
}
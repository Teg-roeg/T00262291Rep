using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeLook : MonoBehaviour
{
    private Vector2 mD;


    private Transform myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody = this.transform.parent.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mC = new Vector2
            (Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mD += mC;

        this.transform.localRotation = Quaternion.AngleAxis(-mD.y, Vector3.right);

        myBody.localRotation = Quaternion.AngleAxis(mD.x, Vector3.up);


        if (this.transform.rotation.eulerAngles.x < 65f ||
            this.transform.rotation.eulerAngles.x > 360f - 65f)
        {
            mD += mC;
        }
        else
            mD.y -= mC.y * 3f;
        // Multiply by 3f in order to create a little 'bounce'
        // so that user does not rotate beyond threshold.
    }
}

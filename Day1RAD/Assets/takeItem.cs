using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class takeItem : MonoBehaviour
{


    private ObjectGrabbable objectGrabbable;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (objectGrabbable == null) {
                float pickUpDistance = 2f;
                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit raycastHit, pickUpDistance))
                {
                    if (raycastHit.transform.TryGetComponent(out objectGrabbable)) ;
                    {
                        objectGrabbable.Grab(transform);
                    }
                }
            } 
        }


        if (Input.GetKeyDown(KeyCode.Q)) {
            objectGrabbable.Drop();
            objectGrabbable = null;
        }
        
    }
}

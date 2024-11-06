using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class fpshooter : MonoBehaviour
{
    public GameObject knifeCloneTemplate;
    float speed = 3;// Start is called before the first frame update 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 fpsMovementDit = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDit.Normalize();
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {

            Vector3 fpsMovementDit = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDit.Normalize();
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);
        transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(knifeCloneTemplate, transform.position, transform.rotation);
        }
    }
}

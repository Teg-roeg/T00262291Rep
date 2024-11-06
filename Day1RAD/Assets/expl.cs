using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expl : MonoBehaviour
{
    Rigidbody rb;
    float ExpRad = 10;
    float ExpStr = 1000;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(35 * transform.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimColliders = Physics.OverlapSphere(transform.position, ExpRad);
        foreach (Collider collider in allVictimColliders)
            { 
                Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
            if (rigidbody != null)
                {
                rigidbody.AddExplosionForce(ExpStr, transform.position, ExpRad);
                }
            }
        Destroy(gameObject);
    }

}

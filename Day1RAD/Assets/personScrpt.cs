using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personScrpt : MonoBehaviour
{
    int health = 100;
    int damage = 12;
    Rigidbody rb;
    
    internal void ExplosionAt(Vector3 position, float explosionRadius, float explotionStrenght)
    {
        health -= damage;
        print("Oh sh-" + health.ToString());
        rb.AddExplosionForce(explotionStrenght / 5, position, explosionRadius);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBumper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // get normal between objects
        Vector3 normal = (collision.transform.position - transform.position).normalized;

        // reset velocity
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        // calculating position after collision
        Vector3 posAfterReflect = Vector3.Reflect(collision.transform.position, normal);

        // getting direction for addForce
        Vector3 direction = (posAfterReflect - transform.position).normalized;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction * 8.0f, ForceMode.Impulse);

    }
    private void OnCollisionExit(Collision collision)
    {

        
    }
}

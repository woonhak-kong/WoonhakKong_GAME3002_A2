using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatBumper : MonoBehaviour
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
        Vector3 normal = transform.up;

        //float magnitudeOfCurrentVelocity = collision.gameObject.GetComponent<Rigidbody>().velocity.magnitude;

        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        Vector3 posAfterReflect = Vector3.Reflect(collision.transform.position, normal);
        //collision.transform.position = posAfterReflect;
        Vector3 direction = (posAfterReflect - transform.position).normalized;
        //collision.gameObject.GetComponent<Rigidbody>().velocity = direction.normalized * magnitudeOfCurrentVelocity * 5.0f;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction * 8.0f, ForceMode.Impulse);

    }
}

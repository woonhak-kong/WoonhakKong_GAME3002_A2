using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatBumper : MonoBehaviour
{
    private Color _color;

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
        // same with Bumper;
        Vector3 normal = transform.up;


        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        Vector3 posAfterReflect = Vector3.Reflect(collision.transform.position, normal);
        Vector3 direction = (posAfterReflect - transform.position).normalized;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction * 8.0f, ForceMode.Impulse);

        ScoreManager.AddScore(50);

        _color = GetComponent<MeshRenderer>().material.color;
        GetComponent<MeshRenderer>().material.color = Color.magenta;

        SoundManager.Instance.PlaySound(Sounds.Bumper);
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = _color;
    }
}

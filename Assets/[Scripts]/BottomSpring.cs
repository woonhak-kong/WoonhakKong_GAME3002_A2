using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomSpring : MonoBehaviour
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
        collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
        ScoreManager.AddScore(30);

        _color = GetComponent<MeshRenderer>().material.color;
        GetComponent<MeshRenderer>().material.color = Color.magenta;

        SoundManager.Instance.PlaySound(Sounds.BottomSpring);
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = _color;
    }
}

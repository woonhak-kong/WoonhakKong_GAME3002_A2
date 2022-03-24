using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject Plunger;
    public Transform PlungerStartPoint;


    private float _pulling = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (_pulling == 0)
        {
            Plunger.GetComponent<Rigidbody>().isKinematic = false;
        }
        else
        {
            Plunger.transform.position = Vector3.Lerp(Plunger.transform.position, PlungerStartPoint.position, Time.fixedDeltaTime * 5);
            Plunger.GetComponent<Rigidbody>().isKinematic = true;

        }
    }

    void OnFire(InputValue value)
    {
        Debug.Log("Fire!");
        Debug.Log(value.Get<float>());
        _pulling = value.Get<float>();
    }

    void OnFlipper(InputValue value)
    {
        print("Flipper!");
        float tmp = value.Get<float>();
        print(tmp);
    }
}

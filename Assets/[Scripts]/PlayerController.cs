using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnFire()
    {
        Debug.Log("Fire!");
    }

    void OnFlipper(InputValue value)
    {
        print("Flipper!");
        float tmp = value.Get<float>();
        print(tmp);
    }
}

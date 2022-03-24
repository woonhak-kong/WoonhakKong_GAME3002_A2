using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject Plunger;
    public GameObject LeftFlipper;
    public GameObject RightFlipper;
    public Transform PlungerStartPoint;


    private bool _isPulling = false;
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
        if (_isPulling)
        {
            Plunger.transform.position = Vector3.Lerp(Plunger.transform.position, PlungerStartPoint.position, Time.fixedDeltaTime * 5);
            Plunger.GetComponent<Rigidbody>().isKinematic = true;
            
        }
        else
        {
            Plunger.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    void OnFire(InputValue value)
    {
        _isPulling = value.Get<float>() == 1.0f;
    }

    void OnLeftFlipper(InputValue value)
    {
        if (value.Get<float>() == 1)
        {
            LeftFlipper.GetComponent<HingeJoint>().useMotor = true;
        }
        else
        {
            LeftFlipper.GetComponent<HingeJoint>().useMotor = false;
        }
    }
    void OnRightFlipper(InputValue value)
    {
        if (value.Get<float>() == 1)
        {
            RightFlipper.GetComponent<HingeJoint>().useMotor = true;
        }
        else
        {
            RightFlipper.GetComponent<HingeJoint>().useMotor = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Plunger.transform.position,
            Plunger.GetComponent<SpringJoint>().connectedBody.transform.position);
    }
}

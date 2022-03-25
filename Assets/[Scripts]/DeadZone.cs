using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
   

    private void OnTriggerExit(Collider other)
    {
        print("dead!");
        FindObjectOfType<GameManager>().GameOver();
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform PinballStartPoint;
    public GameObject Pinball;
    public GameObject Door;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        //ScoreManager.ResetScore();
        Pinball.transform.position = PinballStartPoint.position;
        FindObjectOfType<PlaySceneUIManager>().SetGameOverUI();
    }

    public void Restart()
    {
        Door.GetComponent<BoxCollider>().isTrigger = true;
    }
}

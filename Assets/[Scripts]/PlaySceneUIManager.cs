using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneUIManager : MonoBehaviour
{

    public GameObject GameOverUIBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        GameOverUIBox.SetActive(false);
        ScoreManager.ResetScore();
    }

    public void SetGameOverUI()
    {
        GameOverUIBox.SetActive(true);
    }
}

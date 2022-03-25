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
        Time.timeScale = 1.0f;
        FindObjectOfType<GameManager>().Restart();
    }

    public void SetGameOverUI()
    {
        GameOverUIBox.SetActive(true);
        Time.timeScale = 0.0f;
    }
}

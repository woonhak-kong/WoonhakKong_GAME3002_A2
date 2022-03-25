using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text ScoreText;

    private static int Score = 0;

    

    public 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
    }


    public static void AddScore(int score)
    {
        Score += score;
    }

    public static void ResetScore()
    {
        Score = 0;
    }

}

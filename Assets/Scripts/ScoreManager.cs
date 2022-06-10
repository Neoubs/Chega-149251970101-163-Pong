using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public int rightscore;
    public int leftscore;
    public int MaxScore;

    public BallMovement ball;

    // kontrol score 1
    public void AddScore(int increment)
    {
        rightscore += increment;
        ball.ResetBall();
        if(rightscore >= MaxScore)
        {
            GameOver();
        }
    }

    //kontrol score 2
    public void AddScore1(int increment)
    {
        leftscore += increment;
        ball.ResetBall();
        if(leftscore >= MaxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("GameOver");

    }
}

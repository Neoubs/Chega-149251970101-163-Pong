using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Collider2D ball;
    public bool IsRight;
    public bool IsLeft;

    public ScoreManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if(IsRight)
            {
                manager.AddScore1(1);
            }

            else
            {
                manager.AddScore(1);
            }

        }
    }

}

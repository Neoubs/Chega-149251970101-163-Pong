using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;
    public PowerUpManager manager;
    private float timer;
    public float Purge;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallMovement>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }

    }

    private void Remove(float timer)
    {
        timer += Time.deltaTime;
        if (timer > Purge)
        {
            manager.RemovePowerUp(gameObject);
            timer -= Purge;
        }
    }

}

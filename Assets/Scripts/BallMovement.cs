using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rig; 
    public Vector2 speed; 
    public Vector2 resetposition;

    private void Start() 
    { 
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    } 
 
    public void ResetBall()
    {
        transform.position = new Vector3(resetposition.x, resetposition.y);
        
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

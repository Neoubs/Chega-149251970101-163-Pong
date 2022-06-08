using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rig; 
    public Vector2 speed; 

    private void Start() 
    { 
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    } 
 

    // Update is called once per frame
    void Update()
    {
        
    }
}

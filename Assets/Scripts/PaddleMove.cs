using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public KeyCode upKey; 
    public KeyCode downKey; 
    private Rigidbody2D rig;
    public int speed;  
    

    private Vector2 GetInput() 
    { 
        if (Input.GetKey(upKey))
        { 
            return Vector2.up * speed; 
        } 
        else if (Input.GetKey(downKey))
        { 
            return Vector2.down * speed; 
        } 
         
        return Vector2.zero; 
    } 
     
    private void Start() 
    { 
        rig = GetComponent<Rigidbody2D>(); 
    } 

    private void MoveObject(Vector2 movement) 
    { 
    rig.velocity = movement; 
    } 

    private void Update()
    {
        // get input 
        Vector2 movement = GetInput(); 
         
        // move object 
        MoveObject(movement); 
    }
}

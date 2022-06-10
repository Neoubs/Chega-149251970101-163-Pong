using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour 
{ 

    public int spd;

    public void PlayGame() 
    { 
        Debug.Log("Created by Chega - 149251970101-163");
        Debug.Log("Paddle Speed: "+ spd);
        SceneManager.LoadScene("SampleScene");

    } 

    public void OpenAuthor()
    {
        Application.Quit();
    }
} 

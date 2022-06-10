using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scorekiri;
    public Text scorekanan;

    public ScoreManager manager;
    
    private void Update()
    {
        scorekiri.text = manager.leftscore.ToString();
        scorekanan.text = manager.rightscore.ToString();
    }

}

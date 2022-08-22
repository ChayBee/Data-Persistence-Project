using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerMain : MonoBehaviour
{
    public Text highScoreText;


    void Awake()
    {
        PersistenceManager.instance.LoadHighScore();
        if (PersistenceManager.instance.highScore)
        {
            highScoreText.text = "Best Score: " + PersistenceManager.instance.highScore + " (" + PersistenceManager.instance.highScoreName + ")";
        }
    }
    
}

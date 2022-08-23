using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerMain : MonoBehaviour
{
    public Text highScoreText;


    void Awake()
    {
        // load high score and scorer
        PersistenceManager.instance.LoadHighScore();

        // if loaded high score greater than 0, display the high score and scorer
        if (PersistenceManager.instance.highScore != 0)
        {
            highScoreText.text = "Best Score: " + PersistenceManager.instance.highScore + " (" + PersistenceManager.instance.highScoreName + ")";
        } 
        else
        {
            highScoreText.text = "No Best Score";
        }
    }
    
}

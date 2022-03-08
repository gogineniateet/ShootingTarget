using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject youWin;
    public GameObject gameOver;
    public  bool isGameWin = false;
    public float time;

    private void Update()
    {
        scoreText.text = score.ToString();
        time = time + Time.deltaTime;
        if ((time > 10f) && (isGameWin == false))    
        {            
            gameOver.SetActive(true);
        }
    }
    public void ScoreUpdate(int scoreValue)
    {
        
        score = score + scoreValue;
        Debug.Log("Score : " + score);

        
            if (score >= 20)
            {
                youWin.SetActive(true);
                isGameWin = true;
            }
             

    }
}

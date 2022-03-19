using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject youWin;
    public GameObject gameOver;
    public  bool isGameWin = false;
    public bool isGameOver = false;
    public float time;
    public GameObject playAgainButton;
    public Button playAgain;

    public void Update()
    {
        scoreText.text = score.ToString();
        time = time + Time.deltaTime;
        if ((time > 10f) && (isGameWin == false))    
        {            
            gameOver.SetActive(true);
            isGameOver = true;
            playAgainButton.SetActive(true);
            Button btn = playAgain.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

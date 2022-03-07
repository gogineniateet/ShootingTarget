using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject youWin;
    public  bool isGameWin;

    private void Update()
    {
        scoreText.text = score.ToString();
    }
    public void ScoreUpdate(int scoreValue)
    {
        
        score = score + scoreValue;
        Debug.Log("Score : " + score);
        if(score >=20)
        {
            youWin.SetActive(true);
            isGameWin = true;
        }
    }
}

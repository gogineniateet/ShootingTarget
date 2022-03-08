using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetPrefab;
    public ScoreManager score;

    void Start()
    {
        InvokeRepeating("SpawnMethod",1f,1f);
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();       
    }
    
    void Update()
    {
        CancelInvoke("SpawnMethed");        
    }

    private void SpawnMethod()
    {
        if(score.isGameWin == false)
        {
            float randomX = UnityEngine.Random.Range(-4.5f, 4.5f);
            float randomY = UnityEngine.Random.Range(-2.3f, 2.3f);
            Instantiate(targetPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
        }
    }
}

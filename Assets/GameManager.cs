using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject targetPrefab;
    ScoreManager score;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMethod",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnMethod()
    {
        float randomX = UnityEngine.Random.Range(-4.5f, 4.5f);
        float randomY = UnityEngine.Random.Range(-2.3f, 2.3f);
        Instantiate(targetPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackground : MonoBehaviour
{
    public Color[] colors = new Color[5];
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 5f)
        {
            Camera.main.backgroundColor = colors[Random.Range(0,5)];
            time = 0f;
        }
    }
}

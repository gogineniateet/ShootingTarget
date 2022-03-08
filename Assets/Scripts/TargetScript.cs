using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetScript : MonoBehaviour
{
    ScoreManager score;
    private AudioSource audioSource;
    public AudioClip arrowSound;
    private void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {

        Destroy(gameObject);
        score.ScoreUpdate(5);
        audioSource.clip = arrowSound;
        audioSource.Play();

    }
}

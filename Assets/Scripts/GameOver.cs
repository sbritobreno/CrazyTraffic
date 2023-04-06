using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool gameOver = false;
    [SerializeField] private AudioSource crash;
    [SerializeField] private AudioSource engine;
    [SerializeField] private AudioSource bgMusic;

    void Start()
    {
        // Reset the gameOver variable to false when the scene starts
        gameOver = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Hazard") && !gameOver)
        {
            engine.Pause();
            crash.Play();
            bgMusic.Play();
            FreezeScene();
            gameOver = true;
            //Finish function locate in Timer.cs script.
            GameObject.Find("Player").SendMessage("Finish");
        }
    }

    void FreezeScene()
    {
        Time.timeScale = 0f;
    }
}
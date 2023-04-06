using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject endMenu;
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool finished = false;

    private void Start()
    {
        endMenu = GameObject.Find("EndMenu");
        endMenu.SetActive(false);
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finished)
            return;

        float t = Time.time - startTime;

        string seconds = t.ToString("f0");

        timerText.text = "Score: " + seconds;
    }

    public void Finish()
    {
        finished = true;
        endMenu.SetActive(true);
    }
}

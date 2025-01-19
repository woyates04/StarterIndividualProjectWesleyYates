using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;

   

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = false;
        Invoke("startTime", 2f);
        StartCoroutine(timeleft());
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }

            else
            {
                Debug.Log("Game Over");
                timeRemaining = 0;
                timerIsRunning = false;
                gameOver();
            }
        }

        GameObject[] Icecubes = GameObject.FindGameObjectsWithTag("IceCube");
        
        if (Icecubes.Length == 0)
        {
            SceneManager.LoadScene("WinScreen");
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void gameOver ()
    {
        Time.timeScale = 0f;
    }

    void startTime()
    {
        timerIsRunning = true;
    }

    IEnumerator timeleft()
    {
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene("LoseScreen");
    }
}

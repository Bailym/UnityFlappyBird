using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gameStarted;       //tap to start 
    public bool gameOver;           //player has died
    public TextMeshProUGUI scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        playerDied();
        scoreCounter.text = "Tap to Start!";
        gameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerDied()
    {
        Time.timeScale = 0;
        gameOver = true;
        gameStarted = false;

    }

    public void startGame()
    {
        Time.timeScale = 1;
        gameStarted = true;
        gameOver = false;
        scoreCounter.text = "0";
    }

    public void increaseScore()
    {
        int newScore = int.Parse(scoreCounter.text) + 1;
        scoreCounter.text = newScore.ToString();
    }
}

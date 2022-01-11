using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gameStarted;
    public TextMeshProUGUI scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        endGame();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endGame()
    {
        Time.timeScale = 0;
        gameStarted = false;
    }

    public void startGame()
    {
        Time.timeScale = 1;
        gameStarted = true;
    }

    public void increaseScore()
    {
        Debug.Log("Here");
        int newScore = int.Parse(scoreCounter.text) + 1;
        scoreCounter.text = newScore.ToString();
    }
}

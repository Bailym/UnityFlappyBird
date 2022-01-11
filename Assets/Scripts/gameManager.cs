using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public bool gameStarted;
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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    private Rigidbody2D body;
    private Transform playerTransform;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            if (!gameManager.GetComponent<gameManager>().gameStarted && !gameManager.GetComponent<gameManager>().gameOver)  //if game has not yet started and player is not dead.
            {
                gameManager.GetComponent<gameManager>().startGame();
            }
            else if(gameManager.GetComponent<gameManager>().gameOver) //if the player has died
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                body.velocity = (Vector2.up * 4);
            }
            
            
        }

    }
}

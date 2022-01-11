using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private Rigidbody2D body;
    private Transform playerTransform; 


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
            body.velocity = (Vector2.up * 4);
        }

    }
}

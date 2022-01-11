using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorePoint : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.tag == "Pipe")
        {
            manager.GetComponent<gameManager>().increaseScore();
        }

    }
}

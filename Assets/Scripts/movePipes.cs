using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipes : MonoBehaviour
{
    private Transform pipeTransform;
    public float despawnXPos;

    // Start is called before the first frame update
    void Start()
    {
        pipeTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = pipeTransform.position.x;

        if (xPos <= despawnXPos)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * 150 * Time.deltaTime;
    }

    
}

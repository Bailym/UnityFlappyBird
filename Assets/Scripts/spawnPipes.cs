using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipes : MonoBehaviour
{

    public List<GameObject> prefabPipes;
    public Vector2 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0.5f, 1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
      

        
    }


    void SpawnPipes()
    {
        int len = prefabPipes.Count;

        int randNum = Random.Range(0, len);

        Instantiate(prefabPipes[randNum], spawnPos, Quaternion.identity);
    }
}

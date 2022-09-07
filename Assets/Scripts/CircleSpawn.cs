using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    [SerializeField]
    Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(spawnPoints);
            GameObject enemy = Instantiate(Resources.Load("Prefabs/Circle"), spawnPoints[i]) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

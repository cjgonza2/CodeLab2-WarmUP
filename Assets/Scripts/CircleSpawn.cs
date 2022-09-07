using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    
    public Sprite[] circleColors;
    
    [SerializeField]
    Transform[] spawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        //spawns a circle for each interger i.
        for(int i = 0; i < 10; i++)
        {
            //Debug.Log(spawnPoints);
            GameObject enemy = Instantiate(Resources.Load("Prefabs/Circle"), spawnPoints[i]) as GameObject; //instatiates circle prefabs as gameobjects, sets them to spawnpoints.

            int colorValue = GetComponent<ColorPicker>().SetSprite();
            enemy.GetComponent<SpriteRenderer>().sprite = circleColors[colorValue];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

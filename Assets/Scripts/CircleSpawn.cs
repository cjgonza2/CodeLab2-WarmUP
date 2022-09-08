using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    
    public Sprite[] circleColors;

    public float enemySpeed;
    public int colorValue;
    
    [SerializeField]
    Transform[] spawnPoints;

    public int SetDirection()
    {
        return Random.Range(-10, 11); //returns a random value that will determine the direction.
    }


    // Start is called before the first frame update
    void Start()
    {
        SpawnCircle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnCircle()
    {
        List<GameObject> enemies = new List<GameObject>(); //creates a list of game objects that holds each instatiated clone.

        //spawns a circle for each interger i.
        for(int i = 0; i < 10; i++)
        {
            //Debug.Log(spawnPoints);
            GameObject newEnemy = Instantiate(Resources.Load("Prefabs/Circle"), spawnPoints[i]) as GameObject; //instatiates circle prefabs as gameobjects, sets them to spawnpoints.

            colorValue = GetComponent<ColorPicker>().SetSprite(); //grabs colorpicker component/function and sets a colorvalue based on random number generated.
            newEnemy.GetComponent<SpriteRenderer>().sprite = circleColors[colorValue]; //sets the sprite of the sprite renderer to the assinged sprite in the array based on the colorValue. 
            setSpeed(); //runs set speed function
            Debug.Log(enemySpeed);

            enemies.Add(newEnemy);
            //Debug.Log(SetDirection());
        }

        foreach(GameObject go in enemies) //foreach gameobject in the list of enemeiess
        {
            //Debug.Log("I went through each object");
            Rigidbody2D goRGBD = go.GetComponent<Rigidbody2D>(); //declares a new rigidbody variable and sets game objects rigidbody to it. 
            Vector2 enemyDir = new Vector2(SetDirection(), SetDirection()); //creates vector2 set to the random values returned by setDirection function.
            goRGBD.AddForce(enemyDir * enemySpeed); //adds force based on enemyDir Vector2.         
        }
    }


    public void setSpeed() //based on colorValue determined in For Loop will set the speed value for the enemy. 
    {
       if( colorValue == 0)
        {
            enemySpeed = 2;
        }
       if(colorValue == 1)
        {
            enemySpeed = 3;
        }
       if(colorValue == 2)
        {
            enemySpeed = 4;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    Rigidbody2D enemyBody;

    public void Start()
    {
        Invoke("CheckSpeed", 3);
    }

    public void Update()
    {

    }




    public void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag == "Wall")
        {
           /* Debug.Log("I hit a wall");
            enemyBody = GetComponent<Rigidbody2D>();
            enemyBody.velocity = enemyBody.velocity * -1;*/
        } 
    }

    public void CheckSpeed()
    {
        Debug.Log("I was Called");
    }
}

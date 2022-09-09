using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    public Rigidbody2D myBody;
    
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        float horizontalDir = Input.GetAxisRaw("Horizontal"); //creates a float value for horizontal direction
        float verticalDir = Input.GetAxisRaw("Vertical"); //creates a float for vertical direciton. 
        Vector2 playerDir = new Vector2(horizontalDir, verticalDir);
        myBody.AddForce(playerDir * moveSpeed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("you hit an enemy and died!");
            SceneManager.LoadScene("Lose Scene");
        }
    }
}

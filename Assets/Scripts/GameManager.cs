using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; //for future reference you need this in order to utilize TMPros as a component. 

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI timerText; /// <summary>
    /// When using a TextMeshPro component instead of the legacy Text component
    /// You have to use TextMeshProUGUI in whatever script you're trying to have use
    /// the textmeshpro.
    /// </summary>
    
    public float timer;
    public float roundedTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
    }

    // Update is called once per frame
    void Update()
    {

        timerText.text = "" + roundedTimer;
        
        if(timer > 0)
        {
            timer -= Time.deltaTime; //subtracts from the timer equal to delta time. 
        }

        roundedTimer = Mathf.Round((timer * 10.0f) * 0.1f); //rounds the timer value to a whole number. 

        if(timer <= 0) //when the timer reaches 0.
        {
            Debug.Log("Timer is done, Game Over");
        }
    }
}

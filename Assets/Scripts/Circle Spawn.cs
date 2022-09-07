using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //calls the spawncircle function on start. 
        SpawnCircle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCircle()
    {
        //creates a game object from an instantiated prefab.
        GameObject circle = Instantiate(Resources.Load("Prefabs/Circle")) as GameObject;
    }

    private void OnMouseDown()
    {
        
    }
}

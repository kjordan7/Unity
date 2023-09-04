using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
//information before we start:

//create variables
//variables help us store, manipulate and refer to info
//have names, contain data, and is a particular type

//example int hitPoints 20;
//float speed 3.8f;
//bool isAlive = true;
//string myName = Jordan;

    //[SerializeField]float xValue = 0f;
   
    //[SerializeField]float zValue = 0f;
// variable make it easy to find and easy to manipulate


    // Start is called before the first frame update (happens once)

    [SerializeField]float playerSpeed = 10f;
    //methods = functions
    void Start()
    {   
        PrintInstructions();
        
        //accessing the transform on the game object -transform
        //Translate - Unity built in to have an gameObject to move
        //transform.Translate (1,0,0);
        //this will move object one unity unit on the X axis
    }

    // Update is called once per frame (every time (tick) the script is alive)
    // this will move object .01 unity unit on the x axis continously
    //time.DeltaTime= use info on computer to play the same on frame independent
    void Update()
    {
        
        PlayerMovement();
    }
    void PrintInstructions()
    {

        Debug.Log("Welcome to the Game.");
        Debug.Log("Move your player with WASD or Arrow Keys");
        Debug.Log("Don't hit the wall!");
    

    }

    void PlayerMovement(){

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;  
        transform.Translate (xValue, 0, zValue);

    }

}

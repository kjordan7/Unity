using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
  //information and comments in green with two slashes(//).


  //variables help us store, manipulate and refer to information in Unity Engine.

  //Examples:
  //int hitPoints = 20;
  //float speed = 3.8f;
  //bool isAlive = true;
  //string myName = Jordan;


  //create variables here:

  [SerializeField] float playerSpeed = 10f;
  //Creatng a float variable (numbers with decimals) calledplayerSpeed and setting it to 10 units.
  // [SerializeField] makes variables easy to find and manipulate in Unity Editor.

  public string playerInstructionsOne;
  public string playerInstructionsTwo;
  // creating open text strings to give instructions to players.
  

  void Start()
  //void = functions
  // Start is called before the first frame update (happens once in the script).
  {

    //set text variables  to Introduce players to the game.
    playerInstructionsOne = "Welcome to the Game!";
    playerInstructionsTwo = "Move your player with WASD or Arrow Keys!";

    //Print text variables to the output console in Unity.
    Debug.Log(playerInstructionsOne);
    Debug.Log(playerInstructionsTwo);
    }


  // Update is called once per frame (every time (tick) the script is alive)
  void Update()
  {
    //set two local variables to move in four directions: up, down, left, and right
    //with the speed of the player and syncing frames for different devices.
    float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
    float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

    //move the player on the X and Z axes using the input variables.
    transform.Translate(moveX, 0, moveZ);
    

  }
}

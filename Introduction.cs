using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionScript : MonoBehaviour
{
    //Variables are entered here
    public string myIntroduction;

  //creating a string variable myIntroduction.
    [SerializeField] public string myQuote;

    //creating a string variable myQuote.
    [SerializeField] public int oneInteger;

    //creating an integer variable oneInteger.
    [SerializeField] public float oneFloat;

//creating a float(number with decimals) oneFloat.
  public bool chooseWisely;

  //creating a boolean variable chooseWisely.



  //Function Start is called before the first frame update
  void Start()
  {

    //setting variables to their data:
    //string to characters and words.
    //numbers to number data (Note: an f must be placed wen setting float variables so that 
    // Unity knows it is a float variable).
    //boolean to either true or false.
    myIntroduction = "My name is Jordan";
    myQuote = "Puyo!";
    chooseWisely = true;
    oneInteger = 1;
    oneFloat = 10.25f;


    //This will print each variable to the console window once
    Debug.Log(myIntroduction);
    Debug.Log(myQuote);
    Debug.Log(chooseWisely);
    Debug.Log(oneInteger);
    Debug.Log(oneFloat);


    //Moves the sphere 1 unit  on the Z axis once.
    //transform.Translate(0,0,onefloat);
  }

  // Update is called once per frame (happens as long as the script is alive).
  void Update()
  {

    //Moves the sphere 10.25 units on the Z axis continuously.
    //transform.Translate(0,0,oneInteger);
  }
}


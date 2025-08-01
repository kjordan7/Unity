using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    [SerializeField]float moveX;
    string myIntroduction;
    string myQuote;
    float moveY;
    float moveZ;
    bool myChoice = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myIntroduction = "My name is Jordan";
        myQuote = "Puyo!";
        moveX = 5f;
        moveY = 0;
        moveZ = 0;
        myChoice = false;
        
        
        Debug.Log(myIntroduction);
        Debug.Log(myQuote);






    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveX * Time.deltaTime, moveY, moveZ);
        
    }
}

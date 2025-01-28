using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
  int number = 300;
  string text = "welcome";

    // Update is called once per frame
    void Start()
    {
        Debug.Log("Welcome my son");
        if (number>100){
             Debug.Log("the number is bigger than 100");

        }
        else{
             Debug.Log("the number is smaller than 100");
        }
       
    }
}  
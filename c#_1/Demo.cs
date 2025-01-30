using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
  int number = 300;
  string text = "welcome";
  private string secretLevel = "Top secret Level ";
 
  
    // Update is called once per frame
    void Start()
    {
        Debug.Log("Welcome my son");
        int[] numbers = {2,4,6,8};
        List<string> Enimies = new List<string>();
        Enimies.Add("Rex");
        Enimies.Add("Witch");
        Enimies.Add("Goblin");
        if (number>100){
             Debug.Log("the number is bigger than 100");

        }
        else{
             Debug.Log("the number is smaller than 100");
        }
        for (int pushups = 0; pushups <= 40; pushups++)
          {
            Debug.Log("Pushups counter:" + pushups );

           }
       int result =  punchline(10,11);
   
      
       
    }  
   int punchline(int num1, int num2){

        return num1+num2;
   }
   
}   

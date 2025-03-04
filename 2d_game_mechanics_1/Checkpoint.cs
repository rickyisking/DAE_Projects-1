using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour

{
    public static Vector3 CurrentRespawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        

       
    }
    
    // Update is called once per frame
    void Update()
    {
       CurrentRespawnPoint = transform.position; 
    }
    void OnTriggerEnter2D(Collider2D other){
            if (other.CompareTag("Player")){
                Debug.Log("there was collison");
            }
    
    }
}

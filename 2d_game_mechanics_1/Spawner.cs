using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{
    public GameObject objectToSpawn;
    
    public Transform spawnPoint;   
// Start is called before the first frame update
    void Start()
    {
       StartCoroutine(SpawnObject());
      
    }

    private IEnumerator SpawnObject()
    {
        GameObject gb = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        yield return new WaitForSeconds(10);

        Destroy(gb);
        yield return new WaitForSeconds(5);
        spawner();

        
        
    }
    void spawner(){
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);

    } 



}

   
    


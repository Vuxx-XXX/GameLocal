using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacTus : MonoBehaviour
{
    public GameObject Cactus1, Cactus2, Cactus3, Spawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewCactus", 3, 2.5f);
        
    }
    private void Update()
    {
        
    }
    // Update is called once per frame
    void SpawnNewCactus()
    {
        if (Random.Range(1, 4) == 1){
            Spawn = Instantiate(Cactus1, transform.position, Quaternion.identity) as GameObject;
        }else if (Random.Range(1, 4) == 2)
        {
            Spawn = Instantiate(Cactus2, transform.position, Quaternion.identity) as GameObject;
        }else
            Spawn = Instantiate(Cactus3, transform.position, Quaternion.identity) as GameObject;
    }
}

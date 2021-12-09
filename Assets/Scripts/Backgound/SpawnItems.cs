using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject Item1, Item2, Item3, Item4;
    private GameObject Spawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewItems", 3, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnNewItems()
    {
        if (Random.Range(1, 5) == 1)
            Spawn = Instantiate(Item1, transform.position, Quaternion.identity) as GameObject;
        else if (Random.Range(1, 5) == 2)
            Spawn = Instantiate(Item2, transform.position, Quaternion.identity) as GameObject;
        else if (Random.Range(1, 5) == 3)
            Spawn = Instantiate(Item3, transform.position, Quaternion.identity) as GameObject;
        else
            Spawn = Instantiate(Item4, transform.position, Quaternion.identity) as GameObject;
    }
}

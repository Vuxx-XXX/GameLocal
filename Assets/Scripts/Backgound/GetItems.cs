using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    public PlayerScript charac;
    // Start is called before the first frame update
    void Start()
    {
        charac = gameObject.GetComponentInParent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("item"))
        {
            Destroy(collision.gameObject);
            Score.scoreValue++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionCheck : MonoBehaviour
{
    public PlayerScript movement;
    public GameObject gameoverui;
    public static bool gameispaused;
    // Start is called before the first frame update
    public void Newgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameispaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Character"))
        {
            PlayerScript.wasDead = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Trap")
        {
            movement.enabled = false;
            gameoverui.SetActive(true);
            Time.timeScale = 0f;
            gameispaused = true;
        }
    }

}

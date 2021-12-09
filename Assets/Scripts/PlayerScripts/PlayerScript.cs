using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    public float jumpForce = 5f;
    public float scrollingSpeed = 0.1f;
    private Rigidbody2D character;
    private Animator anim;
    public bool isGrounded = true, isJumping = false;
    public static bool wasDead = false;
    
    void Start()
    {
        wasDead = false;
        character = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
           
            character.velocity = Vector2.up * jumpForce;
        }
        anim.SetBool("isGrounded", isGrounded);
        anim.SetBool("isJumping", isJumping);

    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + scrollingSpeed, transform.position.y, transform.position.z);
        if (wasDead)
        {
            SceneManager.LoadScene(0);
            
        }

    }
}

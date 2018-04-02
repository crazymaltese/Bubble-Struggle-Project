using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    //the speed of the player
    public float speed = 4f;
    private float movement = 0f;
    //to set rigidbody
    public Rigidbody2D rb;



    void Update()
    {
        //specifies what input you want to get and then multiply with the speed
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    private void FixedUpdate()
    {
        //the actaul movment where the movment then works.
        // set to be as fast as the users framerate with fixedDeltaTime
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
    }

    //to kill the player to end with loss
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "ball")
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }
}
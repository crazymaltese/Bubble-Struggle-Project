using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{

    // The start force of the ball
    public Vector2 startForce;
    // To connect the rigidbody effect
    public Rigidbody2D rb;
    //public int counter = 20;

    public GameObject nextBall;

    // Use this for initialization
    void Start()
    {
        rb.AddForce(startForce, ForceMode2D.Impulse);

    }
    void Update()
    {
        
            /*if (counter <= 0)
            {
                SceneManager.LoadScene("Menu");
            }*/
   
    }

    public void Split()
    {
        if (nextBall != null)
        {
            GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<ball>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<ball>().startForce = new Vector2(-2f, -5f);
        }
        Destroy(gameObject);

        /*if (nextBall == null)
        {
            counter--;
            Debug.Log(counter);

        }*/
    }

}


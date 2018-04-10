using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chainCollision : MonoBehaviour
{
    public int counter = 31;
    
     void Update()
    {
        if (counter <= 0)
         {
             SceneManager.LoadScene("Menu");
         }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        chainScript.isFired = false;
        if (col.tag == "ball")
        {
            counter--;
            Debug.Log(counter);
            col.GetComponent<ball>().Split();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainCollision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        chainScript.isFired = false;
        if (col.tag == "ball")
        {
            col.GetComponent<ball>().Split();
        }
    }
}

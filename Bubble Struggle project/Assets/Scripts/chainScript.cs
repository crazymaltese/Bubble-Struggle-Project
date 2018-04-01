using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainScript : MonoBehaviour {

    public Transform player;
    public static bool isFired;
    public float speed;
   

    // Use this for initialization
    void Start()
    {
        //to force the firing not to start before fire
        isFired = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }

        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
            

        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3( 1f, 0f, 1f);
        }

    }
}

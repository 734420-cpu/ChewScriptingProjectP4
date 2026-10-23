using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsandSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is there to tell me the x positon of my object
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //this if statement is going to chech the hight of my object
        if (transform.position.y <= 5f)
        {
            Debug.Log("I am about to hit the ground");
        }
        else
        {
            Debug.Log("I am still in the air");
        
        }
    }
}

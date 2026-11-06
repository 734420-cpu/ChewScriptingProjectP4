using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    //creating the variables for my script
    int cupsInTheSink = 4;

    // Start is called before the first frame update
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("Ive washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

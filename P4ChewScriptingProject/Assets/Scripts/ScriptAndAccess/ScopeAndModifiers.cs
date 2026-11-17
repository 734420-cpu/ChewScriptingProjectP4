using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ScopeAndModifiers : MonoBehaviour
{
    //adding a public variable to class
    public int alpha = 5;

    //adding a private variable to class
    private int beta = 0;
    private int gamma = 0;

    //add access to another class
    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        // change the starting value of alpha
        alpha = 29;
        
        //i can change or access another class
        myOtherClass = new AnotherClass();

        //I am going to use the method in the other class
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}

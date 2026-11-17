using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bannanas;

    private int stapler;
    private int sellotape;


    // Start is called before the first frame update
    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }

    // Update is called once per frame
    private void OfficeSort (int a, int b)
    {
        //create a local variable to the method
        int answer;

        //I can change access
        answer = a + b;

        //print the answer to the console
        Debug.Log("Office Supplies total: " + answer);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type interger
    int myInt = 21;


    // Start is called before the first frame update
    void Start()
    {
        // i'm going to run myint thru my function to multiply it by too
        myInt = MultiplyByTwo(myInt);
        // i'm going to print results to my console
        Debug.Log(myInt);

    }

    // Update is called once per frame
    void Update()
    {

    }
    //CREATING a function that takes a int parameter and multplies it by 2
    int MultiplyByTwo(int number)
    {

        //creating a variavble to store my results
        int results;
        //multiplying the paassed by parameter 2
        results = number * 2;

        //Returning the results
        return results;
    }
}


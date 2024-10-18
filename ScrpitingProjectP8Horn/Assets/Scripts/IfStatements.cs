using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 45.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the coffe's temp. is greater than the hottest drinking temp...
        if (coffeeTemperature > hotLimitTemperature)
        {
            //... do this.
            print("Coffee is too hot.");
        }
        // If it isn't but the coffee temp. is less than the coldest drinking temp...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            //... do this. 
            print("Coffee is just right.");
        }
    }
}

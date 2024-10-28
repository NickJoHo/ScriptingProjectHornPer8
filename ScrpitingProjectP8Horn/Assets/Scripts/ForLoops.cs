using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    private int iterationCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < iterationCount; i++)
        {
            // code to be repeated
        }
        Vector3[] targets = { Vector3.zero, Vector3.up };
        foreach (Vector3 target in targets)
        {
            // code specific to 
        }
    }
}
           




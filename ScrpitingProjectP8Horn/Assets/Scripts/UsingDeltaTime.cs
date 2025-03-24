using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;
    public GameObject light;
    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0.0f)
        {
            if (light != null)
            {
                Light lightComponet = light.GetComponent<Light>();
                if (lightComponet != null)
                {
                    lightComponet.enabled = false;

                }
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
                {
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
            
      
        
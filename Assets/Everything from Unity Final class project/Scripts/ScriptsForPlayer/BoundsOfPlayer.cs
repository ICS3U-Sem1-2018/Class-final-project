using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsOfPlayer : MonoBehaviour
{
    public float xRange = 5.0f;
    public float yRange = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, 0);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange);
        }

        // x position bounderys
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y);
        }
        
    }
}

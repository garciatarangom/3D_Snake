using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private float x=1F, y=1F, z=1F;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.localScale = new Vector3(x, y, z);
        //x += 0.001F;
        
        //y += 0.1F;
        //z += 0.1F;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            x += 0.01F;
            transform.localScale = new Vector3(x, y, z);
        }
    }
}


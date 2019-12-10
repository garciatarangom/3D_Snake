using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    public static Vector3 pos = Vector3.right;
    public float frameRate = 0.2f;
    
    //public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Move", frameRate, frameRate);
    }

    // Update is called once per frame
    void Move()
    {
        transform.position += pos;
    }

    void Update()
    {
        
    }
}

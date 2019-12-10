using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour

{
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        objeto.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            objeto.gameObject.SetActive(true);
        }
    }
}
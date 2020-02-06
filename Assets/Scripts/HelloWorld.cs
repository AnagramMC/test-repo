using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0.0f, 1000, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

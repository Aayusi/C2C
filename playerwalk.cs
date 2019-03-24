using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk : MonoBehaviour
{
    public int playerspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            transform.position = transform.position + Camera.main.transform.forward * playerspeed * Time.deltaTime;
        
        
    }
}

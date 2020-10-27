using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation: MonoBehaviour
{
    private float speed = 3.0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);  
    }
}

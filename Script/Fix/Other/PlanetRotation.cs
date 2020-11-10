using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation: MonoBehaviour
{
   [SerializeField] private float speed = 2.0f;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);  
    }
}

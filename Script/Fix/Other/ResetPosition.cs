 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] private Transform toyRespawnPoint;
    [SerializeField] private ParticleSystem spawnFX;
    [SerializeField] private AudioSource itemDropSFX;
    private Quaternion originalRotationValue;
    private bool hitGround = false;

    void Start()
    {
        originalRotationValue = transform.rotation;
    }
    void Update()
    {
        if (hitGround==true)
        {
            
            hitGround = false;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Reset Trigger")
        {
            transform.position = toyRespawnPoint.transform.position;
            spawnFX.Play();
            itemDropSFX.Play();
            transform.rotation = originalRotationValue;
            hitGround = true;
        }
    }
}

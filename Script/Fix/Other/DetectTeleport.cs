using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTeleport : MonoBehaviour
{
    public static int teleportDetected = 0;
    //public UIManager uIManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            teleportDetected = 1;
            //Destroy(gameObject);
          
    }
}

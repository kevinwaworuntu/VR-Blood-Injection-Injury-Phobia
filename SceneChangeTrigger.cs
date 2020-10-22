using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeTrigger : MonoBehaviour
{
    public static bool sceneTrigger=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Scene Change")
        {
            sceneTrigger = true;
        }
    }

}

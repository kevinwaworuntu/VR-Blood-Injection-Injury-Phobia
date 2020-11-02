using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public ParticleSystem teleportVFx;
   public void ChangeScene()
    {
        StartCoroutine(coChangeScene());
    }
    private IEnumerator coChangeScene()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}

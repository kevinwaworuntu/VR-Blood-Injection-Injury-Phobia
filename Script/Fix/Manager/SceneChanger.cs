using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private ParticleSystem teleportVFx;
   public void ChangeScene()
    {
        StartCoroutine(coChangeScene());
    }
    public void ChangeSceneMain()
    {
        StartCoroutine(coChangeSceneMain());
    }
    public void ChangeSceneTutorial()
    {
        StartCoroutine(coChangeSceneTutorial());
    }
    public void Quit()
    {
        StartCoroutine(coQuit());
    }
    public void ChangeSceneFinal()
    {
        StartCoroutine(coChangeSceneFinal());
    }
    private IEnumerator coChangeScene()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    private IEnumerator coChangeSceneMain()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("PreIntro");

    }
    private IEnumerator coChangeSceneTutorial()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("Tutorial");

    }

    private IEnumerator coQuit()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(5);
        Application.Quit();

    }
    private IEnumerator coChangeSceneFinal()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene("Menu");

    }
}

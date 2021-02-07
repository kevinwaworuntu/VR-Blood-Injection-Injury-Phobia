using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

//Class yang digunakan untuk menampilkan visual effect ketika berpindah scene
public class SceneChanger : MonoBehaviour
{
    [SerializeField] private ParticleSystem teleportVFx;
    [SerializeField] private GameObject teleportGameObject;
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
        teleportGameObject.SetActive(true);
        //teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private IEnumerator coChangeSceneMain()
    {
        teleportGameObject.SetActive(true);
        //teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("PreIntro");
    }
    private IEnumerator coChangeSceneTutorial()
    {
        teleportGameObject.SetActive(true);
        //teleportVFx.Play();
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene("Tutorial");
    }

    private IEnumerator coQuit()
    {
        teleportGameObject.SetActive(true);
        //teleportVFx.Play();
        yield return new WaitForSeconds(5);
        Application.Quit();
    }
    private IEnumerator coChangeSceneFinal()
    {
        teleportGameObject.SetActive(true);
        //teleportVFx.Play();
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene("Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public Text title;
    public bool instructionIsComplete = false;
    public Text instruksi;
    public string[] kumpulanInstruksi;
    public AudioSource audioSource;
    public AudioClip[] audioInstruksi;

    public ParticleSystem teleportVFx;

    public bool stationIsComplete = false;

    protected int i = 0, j = 0, k = 0;
    protected int itemCollected = 0;
    protected int currItem = 0;

    protected virtual IEnumerator SceneChanger()
    {

        teleportVFx.Play();
        yield return new WaitForSeconds(10);    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}

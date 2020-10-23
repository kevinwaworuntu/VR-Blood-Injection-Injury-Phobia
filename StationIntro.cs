using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class StationIntro : GameManager
{
    
    //public GameObject[] directorTimeline;
    public GameObject[] button;
    protected float instructionTime = 1.0f;
    protected float instructionTime2 = 1.0f;
   
    
    /*
    IEnumerator Start()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(5);

        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(5);

        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(5);
        
       // button[0].SetActive(true);
        instructionIsComplete = true;
    }

    
    void Update()
    {
        /*
        if (instructionIsComplete == false)
        {
          
            
           // directorTimeline[0].SetActive(true);
            instruksi.text = kumpulanInstruksi[0];
            
            if (instructionTime >= 5)
            {
                instruksi.text = kumpulanInstruksi[1];
                if (instructionTime >= 10)
                {
                    button[0].SetActive(true);
                }
            }

        }
        if (instructionIsComplete == true)
        {
            StartCoroutine(InstructionText());
            instructionIsComplete = false;
           // Debug.Log(instructionTime2);
           // instructionTime2 += Time.deltaTime;
            //button[0].SetActive(false);
               // directorTimeline[0].SetActive(true);
                
            /*
            if (instructionTime2 >= 8)
            {
                instruksi.text = kumpulanInstruksi[3];
                if (instructionTime2 >= 13)
                {
                    button[1].SetActive(true);
                }
            }
        }
        else
        {

        }
        
    }
    IEnumerator InstructionText()
    {
        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        button[1].SetActive(true);


    }

    public void ButtonClick()
    {
        //directorTimeline[1].SetActive(true);
        instructionIsComplete = true;
    }

    public void ButtonClickSceneChanger()
    {
        StartCoroutine(SceneChanger());
    }
  */
}

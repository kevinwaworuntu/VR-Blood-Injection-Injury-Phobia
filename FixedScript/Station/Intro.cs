using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : GameManager
{
    public InstructionManager iManager;
    public SceneChanger SceneChanger;
    public GameObject[] button;

    // Start is called before the first frame update
    void Start()
    {
        iManager.IntroInstruction();   
    }

    // Update is called once per frame
    void Update()
    {
        
        if (iManager.instructionIsComplete == false)
        {

            // directorTimeline[0].SetActive(true);
            iManager.instruksi.text = iManager.kumpulanInstruksi[0];
            
            if (110>= 5)
            {
                iManager.instruksi.text = iManager.kumpulanInstruksi[1];
                if (110 >= 10)
                {
                    button[0].SetActive(true);
                }
            }

        }
        if (iManager.instructionIsComplete == true)
        {
            //StartCoroutine(InstructionText());
           // instructionIsComplete = false;
           // Debug.Log(instructionTime2);
           // instructionTime2 += Time.deltaTime;
            //button[0].SetActive(false);
               // directorTimeline[0].SetActive(true);
                
            if (110>= 8)
            {
                iManager.instruksi.text = iManager.kumpulanInstruksi[3];
                if (110>= 13)
                {
                    button[1].SetActive(true);
                }
            }
        }
        else
        {

        }
    }
    public void ButtonClick()
    {
        //directorTimeline[1].SetActive(true);
        iManager.instructionIsComplete = true;
    }

    public void ButtonClickSceneChanger()
    {
        SceneChanger.ChangeScene();
    }
}

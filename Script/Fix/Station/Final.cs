using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Final : GameManager
{
    public InstructionManager iManager;
    public SceneChanger sceneChanger;
    [SerializeField] private GameObject[] lightToFade;
    [SerializeField] private float timeRemaining = 45f;
    [SerializeField] private Text timer;
    [SerializeField] private GameObject[] wall;
    [SerializeField] private GameObject[] vFX;
    
    void Start()
    {
        iManager.FinalInstruction();
    }

    
    void Update()   
    {
        if(iManager.instructionIsComplete == true)
        {
            if (stationIsComplete == false)
            {
                countDownTimer();
                vFX[0].SetActive(true);
                vFX[1].SetActive(true);
                //lightToFade[0].intensity = 0;
                lightToFade[0].SetActive(false);
                lightToFade[1].SetActive(true);
                lightToFade[2].SetActive(true);
                lightToFade[3].SetActive(true);
                lightToFade[4].SetActive(true);
                wall[0].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[1].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[2].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[3].SetActive(false);
                wall[6].SetActive(false);
      
                wall[4].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[5].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
               
            }
            else
            {
                timer.text = "";
                sceneChanger.ChangeSceneFinal();
            }
            
        }    
    }

    void countDownTimer()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= Time.deltaTime;       
            timer.text = ((int)timeRemaining).ToString();
        }
        else
        {
            stationIsComplete = true;
        }
    }
}

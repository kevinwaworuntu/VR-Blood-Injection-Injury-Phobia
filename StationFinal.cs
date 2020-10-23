using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StationFinal : GameManager
{
    [SerializeField] private float timeRemaining = 30f;
    [SerializeField] private Text textList;
    [SerializeField] private string textInstruksi;
   
    /*
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update()
    {
        //if (instructionIsComplete) {
            countDownTimer();
        }
       
    }
    IEnumerator InstructionText()
    {
        yield return new WaitForSeconds(5);
    }
    
    void countDownTimer()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= Time.deltaTime;
            textList.text = ((int)timeRemaining).ToString();
        }
    }*/
}

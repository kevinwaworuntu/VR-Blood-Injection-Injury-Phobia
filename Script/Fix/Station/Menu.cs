using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : GameManager
{
    
    public SceneChanger sceneChanger;
    public InstructionManager iManager;

    // Start is called before the first frame update
    void Start()
    {
        iManager.MenuInstruction();

    }

    // Update is called once per frame
    void Update()
    {
       
     
        if (iManager.instructionIsComplete == true)
        {
            ButtonPushed1();
            ButtonPushed2();
            ButtonPushed3();

        }
        else
        {
           
        }
    }
    //return bool if button petunjuk pushed
    public void ButtonPushed1()
    { if (ControllableReactor1.isPushed == true)
        {
            sceneChanger.ChangeSceneTutorial();
            iManager.instruksi.text = iManager.kumpulanInstruksi[5];
            iManager.audioSource.clip = iManager.audioInstruksi[5];
            iManager.audioSource.Play();
            ControllableReactor1.isPushed = false;
        }
    }
    //return bool if button main pushed
    public void ButtonPushed2()
    {
        if (ControllableReactor2.isPushed == true)
        {
            sceneChanger.ChangeSceneMain();
            iManager.instruksi.text = iManager.kumpulanInstruksi[6];
            iManager.audioSource.clip = iManager.audioInstruksi[6];
            iManager.audioSource.Play();
            ControllableReactor2.isPushed = false;
        }
    }
    //return bool if button quit pushed
    public void ButtonPushed3()
    {
        if (ControllableReactor3.isPushed == true)
        {
            sceneChanger.Quit();
            iManager.instruksi.text = iManager.kumpulanInstruksi[7];
            iManager.audioSource.clip = iManager.audioInstruksi[7];
            iManager.audioSource.Play();
            ControllableReactor3.isPushed = false;
        }
    }

}

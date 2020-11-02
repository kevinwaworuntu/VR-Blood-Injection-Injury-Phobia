using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : GameManager
{
    public InstructionManager iManager;
    public SceneChanger sceneChanger;
    //public GameObject button;
   

    // Start is called before the first frame update
    void Start()
    {
        iManager.IntroInstruction1();   
    }

    // Update is called once per frame
    void Update()
    {
            if (iManager.instructionIsComplete == true)
            {
                sceneChanger.ChangeScene();

            }      
    }
}

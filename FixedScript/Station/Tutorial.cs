using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : HiddenObject
{
    //public InstructionManager iManager;
    public SceneChanger sChanger;

    // Start is called before the first frame update
    void Start()
    {
        iManager.TutorialInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        if (stationIsComplete == false)
        {
            cm.CBPosTutorial();
            SceneChangerObject();

        }
        else
        {
            if (sceneChangerDetected == true)

            {
                sChanger.ChangeScene();
                //stationIsComplete = false;
            }
        }
    }
}

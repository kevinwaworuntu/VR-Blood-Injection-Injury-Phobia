using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : HiddenObject
{
    public static int teleportDetected;
    public SceneChanger sChanger;
    public bool btnIsClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        iManager.TutorialInstruction1();
    }

    // Update is called once per frame
    void Update()
    {
        if (iManager.instructionIsComplete == true)
        {
            if (stationIsComplete == false)
            {
                cm.CBPosTutorial();
                SceneChangerObject();
                DetectTeleportPoint();
            }
            else
            {

                if (sceneChangerDetected == true)
                {

                    sChanger.ChangeScene();
                    iManager.TutorialInstruction4();
                    stationIsComplete = false;
                }
                else
                {
                   
                    ButtonIsClicked();
                    SceneChangerObject();
                }
            }
        }
        else
        {

        }
    }
    //return bool if button Click
    void ButtonClick()
    {
        btnIsClicked = true;
        iManager.btn[0].SetActive(false);
    }
    //Check if Button isClicked
    void ButtonIsClicked()
    {
        if (btnIsClicked == true)
        {
            iManager.TutorialInstruction3(); // nanti pindahin ke ButtonClick kalo mau dicoba di Quest
            btnIsClicked = false;
        }
    }
    //Check if Player move to Teleport Point
    void DetectTeleportPoint()
    {
        teleportDetected = DetectTeleport.teleportDetected;
        if(teleportDetected == 1)
        {
            stationIsComplete = true;
            iManager.TutorialInstruction2();
            cm.teleportPointStatus[0].SetActive(false);
            teleportDetected = 0;
        }
    }
}

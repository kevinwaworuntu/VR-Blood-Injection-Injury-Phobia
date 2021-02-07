using UnityEngine;
using UnityEngine.Video;

// This script won't work without a VideoPlayer present,
// so let's ask Unity to enforce that relationship for us.
[RequireComponent(typeof(VideoPlayer))]
public class Tutorial : HiddenObject
{
    public static int teleportDetected;
    public SceneChanger sceneChanger;
    [SerializeField] private VideoClip[] vTutorial;
    [SerializeField] private VideoPlayer vPlayerKanan;
    [SerializeField] private VideoPlayer vPlayerKiri;


    // Start is called before the first frame update
    void Start()
    {
        iManager.TutorialInstruction1();
        vPlayerKanan.clip = vTutorial[0];
        vPlayerKanan.Play();
        vPlayerKiri.clip = vTutorial[3];
        vPlayerKiri.Play();
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

                    sceneChanger.ChangeScene();
                    cm.canvasPosition.SetActive(true);
                    iManager.TutorialInstruction4();
                    Destroy(vPlayerKanan);
                    cm.tutorialCanvas[0].SetActive(false);
                    iManager.instructionIsComplete = false;
                }
                else
                {

                    ButtonPushed();
                    SceneChangerObject();
                }
            }
        }
        else
        {

        }
    }
    //return bool if button Pushed
    public void ButtonPushed()
    { if (ControllableReactor1.isPushed == true)
        {           
            iManager.TutorialInstruction3();
            vPlayerKanan.clip = vTutorial[2];
            vPlayerKanan.Play();
            vPlayerKiri.clip = vTutorial[5];
            vPlayerKiri.Play();
            ControllableReactor1.isPushed = false;
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
            vPlayerKanan.clip = vTutorial[1];
            vPlayerKanan.Play();
            vPlayerKiri.clip = vTutorial[4];
            vPlayerKiri.Play();
            cm.teleportPointStatus[0].SetActive(false);
            teleportDetected = 0;
        }
    }
}

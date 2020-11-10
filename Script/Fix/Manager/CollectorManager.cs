using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorManager : MonoBehaviour
{
    public GameObject canvasPosition;
    public GameObject[] tutorialCanvas;
    public GameObject bagPosition;
    public GameObject[] teleportPointStatus;
    public InstructionManager iManager;
    public UIManager uIManager;
    private int j = 0;
    protected static int itemCollected = 0, currItem = 0;
    
    public void CBPosLevel1()
    {
        itemCollected = DetectOnTrigger.itemCollected;
        if (iManager.instructionIsComplete == true)
        {

            if (itemCollected + j == 0)
            {
                iManager.audioSource.clip = uIManager.itemAudio[0];
                iManager.audioSource.Play();
                teleportPointStatus[0].SetActive(true);
                canvasPosition.transform.position = new Vector3(-9.728f, 1.551f, 2.047f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -45.797f, 0);

                bagPosition.transform.position = new Vector3(-7.87f, 0.778f, 1.507f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 0, 133.068f);
                j++;
            }
            else if (itemCollected + j == 3)
            {
                iManager.audioSource.clip = uIManager.itemAudio[1];
                iManager.audioSource.Play();
                Destroy(teleportPointStatus[0]);
                teleportPointStatus[1].SetActive(true);
                canvasPosition.transform.position = new Vector3(-14.67f, 1.551f, 5.663f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -66.077f, 0);

                bagPosition.transform.position = new Vector3(-13.316f, 0.778f, 6.287f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 0, 171.5f);
                j++;
            }
            else if (itemCollected + j == 6)
            {
                iManager.audioSource.clip = uIManager.itemAudio[2];
                iManager.audioSource.Play();
                Destroy(teleportPointStatus[1]);
                teleportPointStatus[2].SetActive(true);
                canvasPosition.transform.position = new Vector3(-12.522f, 1.551f, 9.576f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -28.335f, 0);

                bagPosition.transform.position = new Vector3(-10.849f, 0.778f, 8.708f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 0, 94.494f);
                j++;
            }
        }
    }
    public void CBPosLevel2()
    {
        itemCollected = DetectOnTrigger.itemCollected;
        /*
        canvasPosition.transform.position = new Vector3(0.101f, 1.712f, -7.973f);
        //Reset Rotation to Zero
        canvasPosition.transform.rotation = Quaternion.identity;
        canvasPosition.transform.Rotate(0, 180, 0);
        */
        //bagPosition.SetActive(false);

        if (iManager.instructionIsComplete == true)
        {

            if (itemCollected + j == 0)
            {
                iManager.audioSource.clip = uIManager.itemAudio[0];
                iManager.audioSource.Play();
                teleportPointStatus[0].SetActive(true);
                canvasPosition.transform.position = new Vector3(-6.159f, 1.629f, -8.851f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -142.721f, 0);

                //bagPosition.SetActive(true);


                bagPosition.transform.position = new Vector3(-6.273f, 0.875f, -7.033f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 180f, 70.25199f);
                

                j++;
            }
            else if (itemCollected + j == 3)
            {
                iManager.audioSource.clip = uIManager.itemAudio[1];
                iManager.audioSource.Play();

                Destroy(teleportPointStatus[0]);
                teleportPointStatus[1].SetActive(true);
                canvasPosition.transform.position = new Vector3(-5.293f, 1.629f, -11.584f);

                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -212.2f, 0);
                /* canvasPosition.transform.position = new Vector3(-6.159f, 1.629f, -11.966f);
                 //Reset Rotation to Zero
                 canvasPosition.transform.rotation = Quaternion.identity;
                 canvasPosition.transform.Rotate(0, -87.936f, 0);
                 */
                bagPosition.transform.position = new Vector3(-7.186f, 0.875f, -10.85f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 180, 105.48f);
          
                j++;
            }
            else if (itemCollected + j == 6)
            {
                iManager.audioSource.clip = uIManager.itemAudio[2];
                iManager.audioSource.Play();
                
                Destroy(teleportPointStatus[1]);
                teleportPointStatus[2].SetActive(true);
                canvasPosition.transform.position = new Vector3(-1.965f, 1.629f, -13.816f);

                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -180.48f, 0);

                bagPosition.transform.position = new Vector3(-1.328f, 0.854f, -13.149f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90, 180, 232.928f);
   
                j++;
            }
            else if (itemCollected + j == 8)
            {
                iManager.audioSource.clip = uIManager.itemAudio[3];
                iManager.audioSource.Play();

                Destroy(teleportPointStatus[2]);
                teleportPointStatus[3].SetActive(true);
                canvasPosition.transform.position = new Vector3(6.206f, 1.615f, -10.887f);

                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -234.422f, 0);

                bagPosition.transform.position = new Vector3(5.766f, 0.854f, -9.013f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90, 180, 312.246f);
       
                j++;
            }/*
            else if (itemCollected + j == 10)
            {
                Destroy(teleportPointStatus[4]);
                teleportPointStatus[5].SetActive(true);
                canvasPosition.transform.position = new Vector3(2.134f, 1.629f, -13.965f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -180.48f, 0);

                bagPosition.transform.position = new Vector3(2.771f, 0.854f, -13.298f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90, 180, 232.928f);
                j++;
            }*/
        }
    }
    public void CBPosTutorial()
    {
        itemCollected = DetectOnTrigger.itemCollected;
        if (iManager.instructionIsComplete == true)
        {
            teleportPointStatus[0].SetActive(true);
            canvasPosition.transform.position = new Vector3(13.855f, 1.716f, 1.823f);
            //Reset Rotation to Zero
            canvasPosition.transform.rotation = Quaternion.identity;
            canvasPosition.transform.Rotate(0, 226f, 0);

            tutorialCanvas[0].transform.position = new Vector3(15.011f, 1.54f, 0.486f);
            //Reset Rotation to Zero
            tutorialCanvas[0].transform.rotation = Quaternion.identity;
            tutorialCanvas[0].transform.Rotate(0, -10.55f, 0);

            bagPosition.transform.position = new Vector3(13.319f, 0.844f, 2.947f);
            //Reset Rotation to Zero
            bagPosition.transform.rotation = Quaternion.identity;
            bagPosition.transform.Rotate(90, 180, 80);

        }
    }
}

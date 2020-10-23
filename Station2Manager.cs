using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Station2Manager : HiddenObject
{
    //public CollectorManager cm;
    /*
    void Start()
    {
        CheckTextList();
        //StartCoroutine(InstructionText());
        //yield return new WaitForSeconds(instructionTime + 10.2f);
    }

    void Update()
    {
        if (stationIsComplete == false)
        {
            HiddenObjectCondition();     
            //CanvasBagPosition();
            //cm.CBPosLevel2();
            CheckTextList();


        }
        else
        {
            StartCoroutine(StationStatusComplete());
            //HiddenObjectCondition();
            SceneChangerObject();
            if (sceneChangerDetected == true)
            {
                StartCoroutine(SceneChanger());
              
                stationIsComplete = false;
            }

        }
    }

    IEnumerator StationStatusComplete()
    {

        if (k == 0) {
            
            audioSource.clip = audioInstruksi[0];
            audioSource.Play();
            instruksi.text = kumpulanInstruksi[2];
            
            k++;
        }
        else if(k == 1)
        {
            Debug.Log("k :" + k);
            itemGameObject[6].SetActive(true);
            yield return new WaitForSeconds(audioSource.clip.length);
            instruksi.text = kumpulanInstruksi[3];
            audioSource.clip = audioInstruksi[1];
            audioSource.Play();
            k++;
        }
        
    }
   /*
    public void CanvasBagPosition()
    {
        itemCollected = DetectOnTrigger.itemCollected;
         
            //canvasPosition.transform.position = new Vector3(0.101f, 1.712f, -7.973f);
            //Reset Rotation to Zero
            //canvasPosition.transform.rotation = Quaternion.identity;
            //canvasPosition.transform.Rotate(0, 180, 0);
            
            //bagPosition.SetActive(false);
       
        if(instructionIsComplete == true)
        {
            
            if (itemCollected + j == 0)
            {
               
                teleportPointStatus[1].SetActive(true);
                canvasPosition.transform.position = new Vector3(-6.159f, 1.629f, -8.851f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -142.721f, 0);

                //bagPosition.SetActive(true);
            
               
                bagPosition.transform.position = new Vector3(-6.273f, 0.875f, -7.033f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 180f, 70.25199f);
                audioSource.clip = audioInstruksi[0];
                audioSource.Play();

                j++;
            }
            else if (itemCollected + j == 3)
            {
                Destroy(teleportPointStatus[1]);
                teleportPointStatus[2].SetActive(true);
                canvasPosition.transform.position = new Vector3(-5.293f, 1.629f, -11.584f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -212.2f, 0);
                // canvasPosition.transform.position = new Vector3(-6.159f, 1.629f, -11.966f);
                 //Reset Rotation to Zero
                 //canvasPosition.transform.rotation = Quaternion.identity;
                 //canvasPosition.transform.Rotate(0, -87.936f, 0);
                 
                bagPosition.transform.position = new Vector3(-7.186f, 0.875f, -10.85f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90f, 180, 105.48f);
                audioSource.clip = audioInstruksi[0];
                audioSource.Play();
                j++;
            }
            else if (itemCollected + j == 6)
            {
                Destroy(teleportPointStatus[2]);
                teleportPointStatus[3].SetActive(true);
                canvasPosition.transform.position = new Vector3(-1.965f, 1.629f, -13.816f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -180.48f, 0);

                bagPosition.transform.position = new Vector3(-1.328f, 0.854f, -13.149f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90, 180, 232.928f);
                audioSource.clip = audioInstruksi[0];
                audioSource.Play();
                j++;
            }
            else if (itemCollected + j == 8)
            {
                Destroy(teleportPointStatus[3]);
                teleportPointStatus[4].SetActive(true);
                canvasPosition.transform.position = new Vector3(6.206f, 1.615f, -10.887f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, -234.422f, 0);

                bagPosition.transform.position = new Vector3(5.766f, 0.854f, -9.013f);
                //Reset Rotation to Zero
                bagPosition.transform.rotation = Quaternion.identity;
                bagPosition.transform.Rotate(90, 180, 312.246f);
                audioSource.clip = audioInstruksi[0];
                audioSource.Play();
                j++;
            }
            //else if (itemCollected + j == 10)
            //{
              //  Destroy(teleportPointStatus[4]);
                //teleportPointStatus[5].SetActive(true);
              //  canvasPosition.transform.position = new Vector3(2.134f, 1.629f, -13.965f);
                //Reset Rotation to Zero
               // canvasPosition.transform.rotation = Quaternion.identity;
               // canvasPosition.transform.Rotate(0, -180.48f, 0);

               // bagPosition.transform.position = new Vector3(2.771f, 0.854f, -13.298f);
                //Reset Rotation to Zero
               // bagPosition.transform.rotation = Quaternion.identity;
               // bagPosition.transform.Rotate(90, 180, 232.928f);
                j++;
            }
        }
    }*/
}

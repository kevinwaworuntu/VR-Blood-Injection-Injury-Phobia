using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Station1Manager : HiddenObject
{
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
            CanvasBagPosition();
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

        if (k == 0)
        {

            audioSource.clip = audioInstruksi[0];
            audioSource.Play();
            instruksi.text = kumpulanInstruksi[2];

            k++;
        }
        else if (k == 1)
        {
            //Debug.Log("k :" + k);
            itemGameObject[6].SetActive(true);
            yield return new WaitForSeconds(audioSource.clip.length);
            instruksi.text = kumpulanInstruksi[3];
            audioSource.clip = audioInstruksi[1];
            audioSource.Play();
            k++;
        }

    }
 
    public void CanvasBagPosition()
    {
        itemCollected = DetectOnTrigger.itemCollected;
        if (instructionIsComplete == true)
        {

            if (itemCollected + j == 0)
            {
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

                //teleportPointStatus[1].SetActive(true);
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
                //teleportPointStatus[2].SetActive(true);
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
}





using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StationTutorialManager : GameManager
{

    //public GameObject[] directorTimeline;
    //[SerializeField] private GameObject[] button;
    [SerializeField] private GameObject objectToDestroy;
    [SerializeField] private GameObject canvasPosition;
    [SerializeField] private GameObject bagPosition;

    //[SerializeField] private GameObject teleportPointStatus;

    protected bool sceneChangerDetected;


    void Start()
    {
        StartCoroutine(InstructionText());
    }

    void Update()
    {
        if (stationIsComplete == false)
        {           
                CanvasBagPosition();
            SceneChangerObject();

        }
        else
        {      
            if (sceneChangerDetected == true)
                
            {
                StartCoroutine(SceneChanger());
                //stationIsComplete = false;
            }
        }
    }
    IEnumerator InstructionText()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(5);
        instruksi.text = kumpulanInstruksi[0];
        yield return new WaitForSeconds(10);
        instruksi.text = kumpulanInstruksi[1];
        yield return new WaitForSeconds(10);
        instruksi.text = kumpulanInstruksi[2];
        yield return new WaitForSeconds(5);
        instruksi.text = kumpulanInstruksi[3];
        yield return new WaitForSeconds(5);
        instruksi.text = kumpulanInstruksi[4];

        instructionIsComplete = true;
        
    }
    public void SceneChangerObject()
    {
        currItem = DetectOnTrigger.itemIndex;
        if (currItem == 7)
        {
            Destroy(objectToDestroy);
            currItem = 0;
            sceneChangerDetected = true;
            canvasPosition.SetActive(false);
            stationIsComplete = true;
        }
    }
  

    public void CanvasBagPosition()
    {
        itemCollected = DetectOnTrigger.itemCollected;
        if (instructionIsComplete == true)
        {

            //if (itemCollected + j == 0)
            //{
                canvasPosition.transform.position = new Vector3(13.855f, 1.716f, 1.823f);
                //Reset Rotation to Zero
                canvasPosition.transform.rotation = Quaternion.identity;
                canvasPosition.transform.Rotate(0, 226f, 0);
            
            bagPosition.transform.position = new Vector3(13.319f, 0.844f, 2.947f);
            //Reset Rotation to Zero
            bagPosition.transform.rotation = Quaternion.identity;
            bagPosition.transform.Rotate(90, 180, 80);
            //  j++;
            //}
        }
    }

}

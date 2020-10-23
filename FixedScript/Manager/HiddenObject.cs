using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class HiddenObject : GameManager
{

    //public GameObject[] teleportPointStatus;

    protected int i = 0, j = 0, k = 0;
    protected static int itemCollected = 0;
    protected static int currItem = 0;
    protected bool sceneChangerDetected;
    public InstructionManager iManager;
    public CollectorManager cm;
    public UIManager uiManager;
    public DetectOnTrigger dOT;

    public void HiddenObjectCondition()
    {
        currItem = DetectOnTrigger.itemIndex;
       
            switch (currItem)
            {
               
                case 1:
                    Destroy(uiManager.itemGameObject[0]);
                uiManager.textList[0].text = "";
                uiManager.imageList[0].sprite = uiManager.completeImage;
                    break;
                case 2:
                    Destroy(uiManager.itemGameObject[1]);
                uiManager.textList[1].text = "";
                uiManager.imageList[1].sprite = uiManager.completeImage;
                    break;
                case 3:
                    Destroy(uiManager.itemGameObject[2]);
                uiManager.textList[0].text = "";
                uiManager.imageList[0].sprite = uiManager.completeImage;
                    break;
                case 4:
                    Destroy(uiManager.itemGameObject[3]);
                uiManager.textList[1].text = "";
                uiManager.imageList[1].sprite = uiManager.completeImage;
                    break;
                case 5:
                    Destroy(uiManager.itemGameObject[4]);
                uiManager.textList[0].text = "";
                uiManager.imageList[0].sprite = uiManager.completeImage;
                    break;
                case 6:
                    Destroy(uiManager.itemGameObject[5]);
                uiManager.textList[1].text = "";
                uiManager.imageList[1].sprite = uiManager.completeImage;
                    break;
                       
        }
    }

    public void SceneChangerObject()
    {
        currItem = DetectOnTrigger.itemIndex;
        if(currItem == 7 && stationIsComplete==true)
        {
            Destroy(uiManager.itemGameObject[6]);
            currItem = 0;
            sceneChangerDetected = true;
            cm.canvasPosition.SetActive(false);
        }
    }
   
    

    public void CheckTextList()
          {
            itemCollected = DetectOnTrigger.itemCollected;
            if (iManager.instructionIsComplete == false)
            {
            uiManager.textList[0].text = "";
            uiManager.textList[1].text = "";
            uiManager.totalItem.text = "";
            uiManager.imageList[0].enabled = false;
            uiManager.imageList[1].enabled = false;
            uiManager.itemGameObject[6].SetActive(false);
        }

            else {

            uiManager.imageList[0].enabled = true;
            uiManager.imageList[1].enabled = true;
                iManager.title.text = "TEMUKAN";
            uiManager.totalItem.text = itemCollected + "/6";

                switch (itemCollected)
                {
                case 0:
                    uiManager.textList[0].text = uiManager.itemName[itemCollected];
                    uiManager.textList[1].text = uiManager.itemName[itemCollected+1];
                    uiManager.imageList[0].sprite = uiManager.itemImage[itemCollected];
                    uiManager.imageList[1].sprite = uiManager.itemImage[itemCollected+1];
                    break;
                case 2:
                    uiManager.textList[0].text = uiManager.itemName[itemCollected];
                    uiManager.textList[1].text = uiManager.itemName[itemCollected+1];
                    uiManager.imageList[0].sprite = uiManager.itemImage[itemCollected];
                    uiManager.imageList[1].sprite = uiManager.itemImage[itemCollected+1];
                    break;
                case 4:
                    uiManager.textList[0].text = uiManager.itemName[itemCollected];
                    uiManager.textList[1].text = uiManager.itemName[itemCollected + 1];
                    uiManager.imageList[0].sprite = uiManager.itemImage[itemCollected];
                    uiManager.imageList[1].sprite = uiManager.itemImage[itemCollected + 1];
                    break;
                case 6:
                    uiManager.textList[0].text = "";
                    uiManager.textList[1].text = "";
                    uiManager.imageList[0].enabled = false;
                    uiManager.imageList[1].enabled = false;

                    uiManager.totalItem.text = "";
                    stationIsComplete = true;
                    break;
            }
        }
    }
}

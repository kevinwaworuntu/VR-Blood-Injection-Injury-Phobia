using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
//[System.Serializable]
public class HiddenObject : GameManager
{
    
    public Image[] imageList;
    public Text[] textList;
    public Sprite[] itemImage;
    public string[] itemName;
    public GameObject[] itemGameObject;
    public Text totalItem;
    public Sprite completeImage;

 
    public GameObject canvasPosition;
    public GameObject bagPosition;
    public GameObject[] teleportPointStatus;

       
    protected float instructionTime = 5.0f;
    //protected int i = 0, j = 0, k=0;
    protected bool sceneChangerDetected;


   
    protected virtual IEnumerator InstructionText()
    {
        instruksi.text = "";
        title.text = "";
        // return new WaitForSeconds(instructionTime+3);
        title.text = "INSTRUKSI";
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(instructionTime);
        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(instructionTime);
        instruksi.text = "";
        instructionIsComplete = true;
       

    }

    public void HiddenObjectCondition()
    {
        currItem = DetectOnTrigger.itemIndex;
       
      
            switch (currItem)
            {
               
                case 1:
                    Destroy(itemGameObject[0]);
                    textList[0].text = "";
                    imageList[0].sprite = completeImage;
                    break;
                case 2:
                    Destroy(itemGameObject[1]);
                    textList[1].text = "";
                    imageList[1].sprite = completeImage;
                    break;
                case 3:
                    Destroy(itemGameObject[2]);
                    textList[0].text = "";
                    imageList[0].sprite = completeImage;
                    break;
                case 4:
                    Destroy(itemGameObject[3]);
                    textList[1].text = "";
                    imageList[1].sprite = completeImage;
                    break;
                case 5:
                    Destroy(itemGameObject[4]);
                    textList[0].text = "";
                    imageList[0].sprite = completeImage;
                    break;
                case 6:
                    Destroy(itemGameObject[5]);
                    textList[1].text = "";
                    imageList[1].sprite = completeImage;
                    break;
                       
        }
    }

    public void SceneChangerObject()
    {
        currItem = DetectOnTrigger.itemIndex;
        if(currItem == 7 && stationIsComplete==true)
        {
            Destroy(itemGameObject[6]);
            currItem = 0;
            sceneChangerDetected = true;
            canvasPosition.SetActive(false);
        }
    }
   
    

    public void CheckTextList()
          {
            itemCollected = DetectOnTrigger.itemCollected;
            if (instructionIsComplete == false)
            {
                textList[0].text = "";
                textList[1].text = "";
                totalItem.text = "";
                imageList[0].enabled = false;
                imageList[1].enabled = false;
                itemGameObject[6].SetActive(false);
        }

            else {
                
                imageList[0].enabled = true;
                imageList[1].enabled = true;
                title.text = "TEMUKAN";
                totalItem.text = itemCollected + "/6";

                switch (itemCollected)
                {
                case 0:
                    textList[0].text = itemName[itemCollected];
                    textList[1].text = itemName[itemCollected+1];
                    imageList[0].sprite = itemImage[itemCollected];
                    imageList[1].sprite = itemImage[itemCollected+1];
                    break;
                case 2:
                    textList[0].text = itemName[itemCollected];
                    textList[1].text = itemName[itemCollected+1];
                    imageList[0].sprite = itemImage[itemCollected];
                    imageList[1].sprite = itemImage[itemCollected+1];
                    break;
                case 4:
                    textList[0].text = itemName[itemCollected];
                    textList[1].text = itemName[itemCollected + 1];
                    imageList[0].sprite = itemImage[itemCollected];
                    imageList[1].sprite = itemImage[itemCollected + 1];
                    break;
                case 6:
                    textList[0].text = "";
                    textList[1].text = "";
                    imageList[0].enabled = false;
                    imageList[1].enabled = false;
                    
                    totalItem.text = "";
                    stationIsComplete = true;
                    break;
            }
        }
    }
}

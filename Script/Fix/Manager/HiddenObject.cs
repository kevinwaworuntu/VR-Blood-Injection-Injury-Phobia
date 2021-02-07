public class HiddenObject : GameManager
{

    protected int i = 0, j = 0, k = 0; 
    protected static int itemCollected = 0;
    protected static int currItem = 0;
    protected bool sceneChangerDetected;
    public InstructionManager iManager;
    public CollectorManager cm;
    public UIManager uIManager;
    public DetectOnTrigger dOT;

    //Fungsi yang akan dipanggil apabila benda tersebunyi ditemukan dan dimasukan kedalam tas
    //Apabila benda tersembunyi ditemukan maka gameObject tersebut akan di destroy dan foto benda akan diganti menjadi gambar centang
    public void HiddenObjectCondition()
    {
        currItem = DetectOnTrigger.itemIndex;
       
            switch (currItem)
            {
               
                case 1:
                    Destroy(uIManager.itemGameObject[0]);
                uIManager.textList[0].text = "";
                uIManager.imageList[0].sprite = uIManager.completeImage;
                    break;
                case 2:
                    Destroy(uIManager.itemGameObject[1]);
                uIManager.textList[1].text = "";
                uIManager.imageList[1].sprite = uIManager.completeImage;
                    break;
                case 3:
                    Destroy(uIManager.itemGameObject[2]);
                uIManager.textList[0].text = "";
                uIManager.imageList[0].sprite = uIManager.completeImage;
                    break;
                case 4:
                    Destroy(uIManager.itemGameObject[3]);
                uIManager.textList[1].text = "";
                uIManager.imageList[1].sprite = uIManager.completeImage;
                    break;
                case 5:
                    Destroy(uIManager.itemGameObject[4]);
                uIManager.textList[0].text = "";
                uIManager.imageList[0].sprite = uIManager.completeImage;
                    break;
                case 6:
                    Destroy(uIManager.itemGameObject[5]);
                uIManager.textList[1].text = "";
                uIManager.imageList[1].sprite = uIManager.completeImage;
                    break;
                       
        }
    }

    //Fungsi yang akan dipanggil apabila sceneChanger object dimasukan kedalam tas
    public void SceneChangerObject()
    {
        currItem = DetectOnTrigger.itemIndex;
        if(currItem == 7 && stationIsComplete==true)
        {
            Destroy(uIManager.sceneObject);
            currItem = 0;
            sceneChangerDetected = true;
            cm.canvasPosition.SetActive(false);
        }
    }
   
    //Fungsi untuk menampilkan foto dan gambar  benda yang harus dicari
    public void CheckTextList()
          {
            itemCollected = DetectOnTrigger.itemCollected;
            if (iManager.instructionIsComplete == false)
            {
            uIManager.textList[0].text = "";
            uIManager.textList[1].text = "";
            uIManager.totalItem.text = "";
            uIManager.imageList[0].enabled = false;
            uIManager.imageList[1].enabled = false;
            uIManager.sceneObject.SetActive(false);
        }

            else {

            uIManager.imageList[0].enabled = true;
            uIManager.imageList[1].enabled = true;
                iManager.title.text = "TEMUKAN";
            uIManager.totalItem.text = itemCollected + "/6";

                switch (itemCollected)
                {
                case 0:
                    uIManager.textList[0].text = uIManager.itemName[itemCollected];
                    uIManager.textList[1].text = uIManager.itemName[itemCollected+1];
                    uIManager.imageList[0].sprite = uIManager.itemImage[itemCollected];
                    uIManager.imageList[1].sprite = uIManager.itemImage[itemCollected+1];
                    break;
                case 2:
                    uIManager.textList[0].text = uIManager.itemName[itemCollected];
                    uIManager.textList[1].text = uIManager.itemName[itemCollected+1];
                    uIManager.imageList[0].sprite = uIManager.itemImage[itemCollected];
                    uIManager.imageList[1].sprite = uIManager.itemImage[itemCollected+1];
                    break;
                case 4:
                    uIManager.textList[0].text = uIManager.itemName[itemCollected];
                    uIManager.textList[1].text = uIManager.itemName[itemCollected + 1];
                    uIManager.imageList[0].sprite = uIManager.itemImage[itemCollected];
                    uIManager.imageList[1].sprite = uIManager.itemImage[itemCollected + 1];
                    break;
                case 6:
                    uIManager.textList[0].text = "";
                    uIManager.textList[1].text = "";
                    uIManager.imageList[0].enabled = false;
                    uIManager.imageList[1].enabled = false;

                    uIManager.totalItem.text = "";
                    stationIsComplete = true;
                    break;
            }
        }
    }
}

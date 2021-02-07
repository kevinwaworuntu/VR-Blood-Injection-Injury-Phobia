using UnityEngine.UI;
using UnityEngine;

public class Final : GameManager
{
    public InstructionManager iManager;
    public SceneChanger sceneChanger;
    [SerializeField] private GameObject timerUI;
    [SerializeField] private GameObject[] lightToFade;
    [SerializeField] private float timeRemaining = 45f;
    [SerializeField] private Text timer;
    [SerializeField] private GameObject[] wall;
    [SerializeField] private GameObject[] vFX;
    
    void Start()
    {
        iManager.FinalInstruction();
    }
    
    void Update()   
    {
        if(iManager.instructionIsComplete == true)
        {
            if (stationIsComplete == false)
            {
                countDownTimer();
                vFX[0].SetActive(true);
                vFX[1].SetActive(true);
                lightToFade[0].SetActive(false);
                lightToFade[1].SetActive(true);
                lightToFade[2].SetActive(true);
                lightToFade[3].SetActive(true);
                lightToFade[4].SetActive(true);
                wall[0].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[1].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[2].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
               
                wall[3].SetActive(false);
                wall[6].SetActive(false);              
                wall[10].SetActive(false);

                wall[12].transform.Translate(Vector3.back * Time.deltaTime * 10, Space.World);
                wall[13].transform.Translate(Vector3.forward * Time.deltaTime * 20, Space.World);

                wall[4].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[5].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[7].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                wall[8].transform.Translate(Vector3.down * Time.deltaTime, Space.World);
            }
            else
            {
                timer.text = "";
                timerUI.transform.position = new Vector3(14.344f, 1.766f, -0.124f);
                timerUI.transform.rotation = Quaternion.identity;
                timerUI.transform.Rotate(0f, 270f, 0f);
                wall[11].SetActive(true);
                sceneChanger.ChangeSceneFinal();
            }     
        }    
    }

    void countDownTimer()
    {
        if (timeRemaining >= 0)
        {
            timerUI.transform.position = new Vector3(15.67853f, 1.564f, 2.151413f);
            timerUI.transform.rotation = Quaternion.identity;
            timerUI.transform.Rotate(0f, 329.554f, 0f);
            timeRemaining -= Time.deltaTime;       
            timer.text = ((int)timeRemaining).ToString();

            if(timeRemaining <= 40) wall[9].SetActive(false);
        }
        else
        {
            stationIsComplete = true;
        }
    }   
}

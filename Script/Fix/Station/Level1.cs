using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : HiddenObject
{
    public SceneChanger sChanger;
    // Start is called before the first frame update
    void Start()
    {
        CheckTextList();
        iManager.HiddenObjectInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        if (stationIsComplete == false)
        {
            HiddenObjectCondition();
            cm.CBPosLevel1();
            CheckTextList();
        }
        else
        {
            StartCoroutine(StationStatusComplete());
            //HiddenObjectCondition();
            SceneChangerObject();
            if (sceneChangerDetected == true)
            {
                sChanger.ChangeScene();
                stationIsComplete = false;
            }

        }
    }
    IEnumerator StationStatusComplete()
    {
        if (k == 0)
        {

            iManager.audioSource.clip = iManager.audioInstruksi[2];
            iManager.audioSource.Play();
            iManager.instruksi.text = iManager.kumpulanInstruksi[2];

            k++;
        }
        else if (k == 1)
        {
            uiManager.itemGameObject[6].SetActive(true);
            yield return new WaitForSeconds(iManager.audioSource.clip.length);
            iManager.instruksi.text = iManager.kumpulanInstruksi[3];
            iManager.audioSource.clip = iManager.audioInstruksi[1];
            iManager.audioSource.Play();
            k++;
        }
    }
}
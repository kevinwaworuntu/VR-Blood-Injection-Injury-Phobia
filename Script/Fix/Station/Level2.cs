using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : HiddenObject
{
    public SceneChanger sceneChanger;
    
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
            cm.CBPosLevel2();
            CheckTextList();


        }
        else
        {
            StartCoroutine(StationStatusComplete());
            SceneChangerObject();
            if (sceneChangerDetected == true)
            {
                sceneChanger.ChangeScene();
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
            uIManager.itemGameObject[6].SetActive(true);
            yield return new WaitForSeconds(iManager.audioSource.clip.length);
            iManager.instruksi.text = iManager.kumpulanInstruksi[3];
            iManager.audioSource.clip = iManager.audioInstruksi[3];
            iManager.audioSource.Play();
            k++;
        }
    }
}

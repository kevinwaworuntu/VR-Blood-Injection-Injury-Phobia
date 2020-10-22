using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StationPreIntro : GameManager
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        instruksi.text = "";
        title.text = "";
        yield return new WaitForSeconds(5);

        title.text = "INSTRUKSI";
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+2);

        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);

        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);

        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);

        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[4];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);

        instruksi.text = "";
        instructionIsComplete = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

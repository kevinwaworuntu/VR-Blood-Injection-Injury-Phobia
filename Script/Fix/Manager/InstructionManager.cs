using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

    public class InstructionManager : MonoBehaviour
    {
        public Text title;
        public bool instructionIsComplete = false;
        public Text instruksi;
        public string[] kumpulanInstruksi;
        public AudioSource audioSource;
        public AudioClip[] audioInstruksi;
        public GameObject[] btn;

    public void PreIntroInstruction()
    {
        StartCoroutine(coPreIntroInstruction());
    }
    public void IntroInstruction1()
    {
        StartCoroutine(coIntroInstruction1());
    }
    public void IntroInstruction2()
    {
        StartCoroutine(coIntroInstruction2());
    }
    public void TutorialInstruction1()
    {
        StartCoroutine(coTutorialInstruction1());
    }
    public void TutorialInstruction2()
    {
        StartCoroutine(coTutorialInstruction2());
    }
    public void TutorialInstruction3()
    {
        StartCoroutine(coTutorialInstruction3());
    }
    public void TutorialInstruction4()
    {
        StartCoroutine(coTutorialInstruction4());
    }
    public void HiddenObjectInstruction()
    {
        StartCoroutine(coHiddenObjectInstruction());
    }
    private IEnumerator coPreIntroInstruction()
    {
            instruksi.text = "";
            title.text = "";
            yield return new WaitForSeconds(5);

            title.text = "INSTRUKSI";
            audioSource.clip = audioInstruksi[0];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);

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
    private IEnumerator coIntroInstruction1()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(5);
        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(5);

        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(5);

        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(5);

        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(5);
        instructionIsComplete = true;
    }
    // gadipake duli
    private IEnumerator coIntroInstruction2()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(5);
        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(5);

        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(5);
    }
    private IEnumerator coTutorialInstruction1()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[0];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[1];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[2];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[3];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[4];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[5];
        instructionIsComplete = true;
    }
    private IEnumerator coTutorialInstruction2()
    {
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[6];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[7];
        yield return new WaitForSeconds(2);
        btn[0].SetActive(true);

    }
    private IEnumerator coTutorialInstruction3()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[8];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[9];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[10];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[11];
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[12];
        

    }
    private IEnumerator coTutorialInstruction4()
    {
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[13];

    }
    private IEnumerator coHiddenObjectInstruction()
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
        yield return new WaitForSeconds(audioSource.clip.length + 2);
        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);
        instruksi.text = "";
        instructionIsComplete = true;


    }
}

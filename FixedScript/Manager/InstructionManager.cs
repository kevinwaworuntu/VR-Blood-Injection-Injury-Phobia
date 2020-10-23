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
    public void TutorialInstruction()
    {
        StartCoroutine(coTutorialInstruction());
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
    private IEnumerator coTutorialInstruction()
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

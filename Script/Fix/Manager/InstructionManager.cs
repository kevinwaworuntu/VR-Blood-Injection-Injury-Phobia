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
        [SerializeField] private Animator[] anim;
        [SerializeField] private GameObject[] gObjects;
       

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
    public void FinalInstruction()
    {
        StartCoroutine(coFinalInstruction());
    }
    public void MenuInstruction()
    {
        StartCoroutine(coMenuInstruction());
    }
    private IEnumerator coPreIntroInstruction()
    {
            instruksi.text = "";
            title.text = "";
            yield return new WaitForSeconds(3);

            instruksi.text = kumpulanInstruksi[0];
            audioSource.clip = audioInstruksi[0];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);

            instruksi.text = kumpulanInstruksi[1];
            audioSource.clip = audioInstruksi[1];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);

            instruksi.text = kumpulanInstruksi[2];
            audioSource.clip = audioInstruksi[2];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);

            instruksi.text = kumpulanInstruksi[3];
            audioSource.clip = audioInstruksi[3];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);
            
            instruksi.text = kumpulanInstruksi[4];
            audioSource.clip = audioInstruksi[4];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);

            instruksi.text = kumpulanInstruksi[5];
            audioSource.clip = audioInstruksi[5];
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length + 2);
            //instruksi.text = "";

            instructionIsComplete = true;
    }
    private IEnumerator coIntroInstruction1()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(3);

        anim[0].SetInteger("Kondisi", 1);
        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+0.5f);

        anim[0].SetInteger("Kondisi", 2);
        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 3);
        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+0.5f);

        anim[0].SetInteger("Kondisi", 4);
        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 0);
        yield return new WaitForSeconds(1);

        anim[0].SetInteger("Kondisi", 5);
        instruksi.text = kumpulanInstruksi[4];
        audioSource.clip = audioInstruksi[4];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 6);
        instruksi.text = kumpulanInstruksi[5];
        audioSource.clip = audioInstruksi[5];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length-1.1f);
        anim[0].SetInteger("Kondisi", 0);
        instructionIsComplete = true;
    }
    // gadipake dulu
    private IEnumerator coIntroInstruction2()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(5);
        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);

        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);
    }
    private IEnumerator coTutorialInstruction1()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(2);
        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);
        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);
        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);
        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 7);
        instruksi.text = kumpulanInstruksi[4];
        audioSource.clip = audioInstruksi[4];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 2);
        instruksi.text = kumpulanInstruksi[5];
        audioSource.clip = audioInstruksi[5];
        audioSource.Play();
        gObjects[0].SetActive(true);
        yield return new WaitForSeconds(audioSource.clip.length + 1);
        instructionIsComplete = true;
    }
    private IEnumerator coTutorialInstruction2()
    {
        instruksi.text = kumpulanInstruksi[6];
        audioSource.clip = audioInstruksi[6];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        instruksi.text = kumpulanInstruksi[7];
        audioSource.clip = audioInstruksi[7];
        audioSource.Play();
       // btn[0].SetActive(true);

    }
    private IEnumerator coTutorialInstruction3()
    {
        instruksi.text = kumpulanInstruksi[8];
        audioSource.clip = audioInstruksi[8];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        instruksi.text = kumpulanInstruksi[9];
        audioSource.clip = audioInstruksi[9];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 1);
        instruksi.text = kumpulanInstruksi[10];
        audioSource.clip = audioInstruksi[10];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length + 1);
        instruksi.text = kumpulanInstruksi[11];
        audioSource.clip = audioInstruksi[11];
        audioSource.Play();


    }
    private IEnumerator coTutorialInstruction4()
    {
        
        instruksi.text = kumpulanInstruksi[12];
        audioSource.clip = audioInstruksi[12];
        audioSource.Play();
        yield return new WaitForSeconds(1);

    }
    private IEnumerator coHiddenObjectInstruction()
    {
        //instruksi.text = "";
        //title.text = "";
        
        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+2);

        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();    
        yield return new WaitForSeconds(audioSource.clip.length + 2);

        instruksi.text = "";
        instructionIsComplete = true;

    }
    private IEnumerator coFinalInstruction()
    {
        instruksi.text = "";
        yield return new WaitForSeconds(3);

        anim[0].SetInteger("Kondisi", 1);
        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 2);
        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length-0.3f);

        anim[0].SetInteger("Kondisi", 3);
        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 4);
        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 5);
        instruksi.text = kumpulanInstruksi[4];
        audioSource.clip = audioInstruksi[4];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 0);
        instruksi.text = "";
        instructionIsComplete = true;    
        yield return new WaitForSeconds(45); //Tunggu Waktu sesuai timer

        anim[0].SetInteger("Kondisi", 6);
        instruksi.text = kumpulanInstruksi[5];
        audioSource.clip = audioInstruksi[5];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length+0.15f);

        anim[0].SetInteger("Kondisi", 7);
        instruksi.text = kumpulanInstruksi[6];
        audioSource.clip = audioInstruksi[6];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 8);
        instruksi.text = kumpulanInstruksi[7];
        audioSource.clip = audioInstruksi[7];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        anim[0].SetInteger("Kondisi", 0);

    }
    private IEnumerator coMenuInstruction()
    {

        instruksi.text = kumpulanInstruksi[0];
        audioSource.clip = audioInstruksi[0];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        instruksi.text = kumpulanInstruksi[1];
        audioSource.clip = audioInstruksi[1];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        instruksi.text = kumpulanInstruksi[2];
        audioSource.clip = audioInstruksi[2];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        instruksi.text = kumpulanInstruksi[3];
        audioSource.clip = audioInstruksi[3];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        instruksi.text = kumpulanInstruksi[4];
        audioSource.clip = audioInstruksi[4];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);

        instruksi.text = kumpulanInstruksi[1];
        instructionIsComplete = true;

    }
}

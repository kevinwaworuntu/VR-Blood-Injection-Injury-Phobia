using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public InstructionManager iManager;

    // Start is called before the first frame update
    void Start()
    {
        iManager.IntroInstruction();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

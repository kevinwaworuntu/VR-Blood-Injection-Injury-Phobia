using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public InstructionManager iManager;
    // Start is called before the first frame update
    void Start()
    {
        iManager.HiddenObjectInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

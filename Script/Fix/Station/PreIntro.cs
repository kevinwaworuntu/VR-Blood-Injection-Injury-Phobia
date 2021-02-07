public class PreIntro : GameManager
{
    public InstructionManager iManager;
    public SceneChanger sceneChanger;
    
    // Start is called before the first frame update
    void Start()
    {
        iManager.PreIntroInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iManager.instructionIsComplete == true)
        {
            sceneChanger.ChangeScene();
         
        }
    }
}
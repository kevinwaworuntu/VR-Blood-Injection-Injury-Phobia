using UnityEngine.Events;
using UnityEngine;

public class DetectOnTrigger : MonoBehaviour
{
    //[SerializeField] private ParticleSystem visualEffect; // nanti hapus
    [SerializeField] private UnityEvent correctItem, wrongItem;

    public static int itemIndex;
    public static int itemCollected;


    public void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case ("Item 1"):
                itemIndex = 1;
                correctItem.Invoke();
                itemCollected++;
                break;
            case ("Item 2"):
                itemIndex = 2;
                correctItem.Invoke();
                itemCollected++;
                break;
            case ("Item 3"):
                itemIndex = 3;
                correctItem.Invoke();
                itemCollected++;
                break;
            case ("Item 4"):
                itemIndex = 4;
                correctItem.Invoke();
                itemCollected++;
                break;
            case ("Item 5"):
                itemIndex = 5;
                correctItem.Invoke();
                itemCollected++;
                break;
            case ("Item 6"):
                itemIndex = 6;
                correctItem.Invoke();
                itemCollected++;
                break;
            case ("Scene Change"):
                itemIndex = 7;
                correctItem.Invoke();
                itemCollected = 0;
                break;
            case ("Toys"):
                wrongItem.Invoke();
                break;
        }
    }
}      /*
        if (other.gameObject.tag == "Item 1")
                {
                    itemIndex = 1;
                    correctItem.Invoke();
                    itemCollected++;
                }
            else if (other.gameObject.tag == "Item 2")
                {
                    itemIndex = 2;
                    correctItem.Invoke();
                    itemCollected++;
                }
            else if (other.gameObject.tag == "Item 3")
                {
                    itemIndex = 3;
                    correctItem.Invoke();
                    itemCollected++;
                }
            else if (other.gameObject.tag == "Item 4")
                {
                    itemIndex = 4;
                    correctItem.Invoke();
                    itemCollected++;
                }
            else if (other.gameObject.tag == "Item 5")
                {
                    itemIndex = 5;
                    correctItem.Invoke();
                    itemCollected++;
                }
            else if (other.gameObject.tag == "Item 6")
                {
                    itemIndex = 6;
                    correctItem.Invoke();
                    itemCollected++;
                }
            else if (other.gameObject.tag == "Scene Change")
                {
                    itemIndex = 7;
                    itemCollected = 0;
                    correctItem.Invoke();
                }

            else if (other.gameObject.tag == "Toys")
                {
                    wrongItem.Invoke();
                }
           */
    
      /*     
     // nanti dihapus
    public void VisualEffect()
    {
        visualEffect.Play();
    }
    */


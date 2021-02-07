using UnityEngine;
using UnityEngine.UI;

// Class yang akan digunakan untuk menampung Image,Teks, GameObject, sprite dan audio clip yang akan digunakan di UI Instruksi
public class UIManager : MonoBehaviour
{
    public Image[] imageList;
    public Text[] textList;
    public Sprite[] itemImage;
    public string[] itemName;
    public AudioClip[] itemAudio;
    public GameObject[] itemGameObject;
    public Text totalItem;
    public Sprite completeImage;
    public GameObject sceneObject;

}

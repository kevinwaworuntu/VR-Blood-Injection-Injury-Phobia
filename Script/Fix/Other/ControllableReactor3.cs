    using UnityEngine;
    using UnityEngine.UI;
    using VRTK.Controllables;

    public class ControllableReactor3 : MonoBehaviour
    {
        public VRTK_BaseControllable controllable;
        //public Text displayText;
        public string outputOnMax = "Maximum Reached";
        public string outputOnMin = "Minimum Reached";
        public static bool isPushed = false;
        private bool wasHit = false;

        protected virtual void OnEnable()
        {
            controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
            //controllable.ValueChanged += ValueChanged;
            controllable.MaxLimitReached += MaxLimitReached;
            controllable.MinLimitReached += MinLimitReached;
        }
    /*
        protected virtual void ValueChanged(object sender, ControllableEventArgs e)
        {
            if (displayText != null)
            {
                displayText.text = e.value.ToString("F1");
            }
        }
        */
    protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
    {
        
        if (outputOnMax != "")
            {
            Debug.Log(outputOnMax);
            //Make button to do action on the first pushed only
            if (wasHit == false) 
            {      
            isPushed = true;
            wasHit =true;
            }
        }
    }

        protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
        {
            if (outputOnMin != "")
            {
                Debug.Log(outputOnMin);
            }
        }
    }

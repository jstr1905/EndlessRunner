using TMPro;
using UnityEngine;

namespace Collectibles
{
    public class CollectibleControl : MonoBehaviour
    {

        public static int coinCount;
        public TextMeshProUGUI coinCountDisplay;

    
        void Update()
        {
       
            coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
        
        }
    }
}

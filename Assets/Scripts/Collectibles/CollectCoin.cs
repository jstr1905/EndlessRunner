using UnityEngine;

namespace Collectibles
{
    public class CollectCoin : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            CollectibleControl.coinCount += 3;
            this.gameObject.SetActive(false);
        }

        
    }
}

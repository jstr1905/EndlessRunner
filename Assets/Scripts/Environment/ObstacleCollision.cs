using UnityEngine;

namespace Collectibles
{
    public class ObstacleCollision : MonoBehaviour
    {
        public GameObject thePlayer;
        public GameObject charModel;
        public GameObject levelControl;
        void OnTriggerEnter(Collider other)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            charModel.GetComponent<Animator>().Play("Stumble Backwards");
            levelControl.GetComponent<LevelDistance>().enabled = false;

        }

        
    }
}

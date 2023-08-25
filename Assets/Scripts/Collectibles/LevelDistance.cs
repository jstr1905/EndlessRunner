using System.Collections;
using TMPro;
using UnityEngine;

namespace Collectibles
{
    public class LevelDistance : MonoBehaviour
    {
        public GameObject disDisplay;
        public int disRun;
        public bool addingDis = false;
        public float disDelay=0.35f;
        void Update()
        {
            if (addingDis==false)
            {
                addingDis = true;
                StartCoroutine(AddingDis());
            }
        }

        IEnumerator AddingDis()
        {
            disRun += 1;
            disDisplay.GetComponent<TextMeshProUGUI>().text = "" + disRun;
            yield return new WaitForSeconds(disDelay);
            addingDis = false;
        }
    }
}

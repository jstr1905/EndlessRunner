using UnityEngine;

namespace Collectibles
{
    public class RotateObject : MonoBehaviour
    {
        public int rotateSpeed = 80;

        void Update()
        {
            transform.Rotate(0,rotateSpeed,0,Space.World);
        }
    }
}
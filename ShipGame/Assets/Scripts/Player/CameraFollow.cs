using UnityEngine;

namespace ShipGame
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float delay = 0.125f;
        public Vector3 CameraOffset;
        private void FixedUpdate()
        {
            Vector3 targetPosition = target.position + CameraOffset;
            Vector3 targetPosition2 = Vector3.Lerp(transform.position, targetPosition, delay);
            transform.position = targetPosition2;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class Rotate : MonoBehaviour
    {
        public int Rotation=70;
        private void Update()
        {
            this.transform.Rotate(0, Rotation * Time.deltaTime, 0);
        }
    }
}

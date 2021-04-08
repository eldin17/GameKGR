using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame.Obstacles.Move 
{   
	public class StopDestroyer : MonoBehaviour
	{
        public ForwardMovement moving;
        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Stop")
            {
                moving.enabled = false;
            }            
        }
    }
}

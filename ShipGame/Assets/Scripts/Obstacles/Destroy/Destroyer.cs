using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame.Obstacles.Destroy 
{   
	public class Destroyer : MonoBehaviour
	{
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.name == "DestroyPoint")
            {
                Destruction();
            }
        }
        void Destruction()
        {
            Destroy(this.gameObject);
        }
    }
}

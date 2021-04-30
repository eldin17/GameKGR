using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class EnemyHealth : MonoBehaviour
    {
        public int health = 10;
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Cannon Ball")
            {
                health--;
                if (health == 0)
                    Destroy(this.gameObject);
            }
        }       
    }
}

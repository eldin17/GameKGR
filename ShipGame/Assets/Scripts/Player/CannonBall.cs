using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class CannonBall : MonoBehaviour
    {
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "World"|| coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "EnemyShip" || coll.gameObject.tag == "Mines" || coll.gameObject.tag == "Health")
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class EnemyCannonBall : MonoBehaviour
    {
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "World" || coll.gameObject.tag == "Player")
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class CannonBall : MonoBehaviour
    {
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "World"|| coll.gameObject.tag == "Enemy")
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

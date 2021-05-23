using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class TowerOff : MonoBehaviour
    {
        public EnemyCanon[] shooting;  

        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Cannon Ball")
            {
                for (int i = 0; i < shooting.Length; i++)
                {
                    shooting[i].Stop = true;
                }
            }
        }
    }
}

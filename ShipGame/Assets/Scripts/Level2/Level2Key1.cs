using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class Level2Key1 : MonoBehaviour
    {
        public EnemyCanon[] shooting;
        public EnemyFollow[] follow;            

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < follow.Length; i++)
            {
                follow[i].enabled = false;
            }
            for (int i = 0; i < shooting.Length; i++)
            {
                shooting[i].Stop = true;
            }            
        }
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Cannon Ball")
            {
                Destroy(this.gameObject);
                for (int i = 0; i < follow.Length; i++)
                {
                    follow[i].enabled = true;
                }
                for (int i = 0; i < shooting.Length; i++)
                {
                    shooting[i].Stop = false;
                }                       
            }
        }
    }
}

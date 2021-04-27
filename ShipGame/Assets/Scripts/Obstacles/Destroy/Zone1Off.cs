using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class Zone1Off : MonoBehaviour
    {        
        public EnemyCanon shooting1;
        public EnemyFollow follow1;
        public EnemyCanon shooting2;
        public EnemyFollow follow2;

        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Cannon Ball")
            {
                
                shooting1.Stop = true;
                follow1.enabled = false;                
                shooting2.Stop = true;
                follow2.enabled = false;
                Destroy(this.gameObject);
                
            }
        }
        private void Update()
        {
            transform.Rotate(0, 70 * Time.deltaTime, 0);
        }
    }
}

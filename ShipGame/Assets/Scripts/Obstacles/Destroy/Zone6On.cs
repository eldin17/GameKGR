using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class Zone6On : MonoBehaviour
    {
        
        public EnemyCanon shooting1;
        public EnemyFollow follow1;
        public EnemyCanon shooting2;
        public EnemyFollow follow2;
        public EnemyCanon shooting3;
        public EnemyFollow follow3;
        public EnemyCanon shooting4;
        public EnemyFollow follow4;

        public EnemyCanon shooting1old;
        public EnemyFollow follow1old;
        public EnemyCanon shooting2old;
        public EnemyFollow follow2old;
        public EnemyCanon shooting3old;
        public EnemyFollow follow3old;

        // Start is called before the first frame update
        void Start()
        {
            follow1.enabled = false;
            shooting1.Stop = true;

            follow2.enabled = false;
            shooting2.Stop = true;

            follow3.enabled = false;
            shooting3.Stop = true;

            follow4.enabled = false;
            shooting4.Stop = true;
        }
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Cannon Ball")
            {
                follow1old.enabled = false;
                shooting1old.Stop = true;

                follow2old.enabled = false;
                shooting2old.Stop = true;

                follow3old.enabled = false;
                shooting3old.Stop = true;

                follow1.enabled = true;
                shooting1.Stop = false;

                follow2.enabled = true;
                shooting2.Stop = false;

                follow3.enabled = true;
                shooting3.Stop = false;

                follow4.enabled = true;
                shooting4.Stop = false;

                Destroy(this.gameObject);
            }
        }
    }
}

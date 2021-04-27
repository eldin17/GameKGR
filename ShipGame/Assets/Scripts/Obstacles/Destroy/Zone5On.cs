using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class Zone5On : MonoBehaviour
    {            
        public EnemyCanon shooting1;
        public EnemyFollow follow1;
        public EnemyCanon shooting2;
        public EnemyFollow follow2;
        public EnemyCanon shooting3;
        public EnemyFollow follow3;
    
        // Start is called before the first frame update
        void Start()
        {
            follow1.enabled = false;
            shooting1.Stop = true;

            follow2.enabled = false;
            shooting2.Stop = true;

            follow3.enabled = false;
            shooting3.Stop = true;
        }
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Cannon Ball")
            {
                follow1.enabled = true;
                shooting1.Stop = false;
                
                follow2.enabled = true;
                shooting2.Stop = false;

                follow3.enabled = true;
                shooting3.Stop = false;

                Destroy(this.gameObject);
            }
        }
        private void Update()
        {
            transform.Rotate(0, 70 * Time.deltaTime, 0);
        }
    }
}

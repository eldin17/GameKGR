using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class PlayerHealth : MonoBehaviour
    {
        public int health = 10;
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Mines")
            {
                Destroy(this.gameObject);

            }
            if (coll.gameObject.tag == "EnemyCannon")
            {
                health--;
                if (health <= 0)
                    Destroy(this.gameObject);

            }
            if (coll.gameObject.tag == "Health")
            {
                health=10;                
                Destroy(coll.gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

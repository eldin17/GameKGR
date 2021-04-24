using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class MineMovement : MonoBehaviour
    {
        public float Move1;
        // Start is called before the first frame update
        void Start()
        {
            this.GetComponent<Rigidbody>().AddForce(transform.forward * Move1);
        }

        // Update is called once per frame
            void OnCollisionEnter(Collision coll)
            {
                if (Move1 > 0)
                {
                    if (coll.gameObject.tag == "Land2")
                    {
                        this.GetComponent<Rigidbody>().AddForce(transform.forward * -Move1);
                    }
                    if (coll.gameObject.tag == "Land1")
                    {
                        this.GetComponent<Rigidbody>().AddForce(transform.forward * Move1);
                    }
                }
                if (Move1 < 0)
                {
                    if (coll.gameObject.tag == "Land1")
                    {
                        this.GetComponent<Rigidbody>().AddForce(transform.forward * -Move1);
                    }
                    if (coll.gameObject.tag == "Land2")
                    {
                        this.GetComponent<Rigidbody>().AddForce(transform.forward * Move1);
                    }
            }
        }       
    }
}

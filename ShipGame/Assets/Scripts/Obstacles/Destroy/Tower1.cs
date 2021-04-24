using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame
{
    public class Tower1 : MonoBehaviour
    {
        public GameObject projectile;
        public float shootForce;        
        public bool Stop = false;
        public float Time1;
        public float Delay1;
        private void Start()
        {
            InvokeRepeating("CanonFire", Time1, Delay1);            
        }
        public void CanonFire()
        {       
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);

            if (Stop)
            {
                CancelInvoke("SpawnObject1");
            }
        }        
    }
}
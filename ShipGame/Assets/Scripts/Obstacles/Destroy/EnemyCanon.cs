using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace ShipGame
{
    public class EnemyCanon : MonoBehaviour
    {
        public AudioSource sound;
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
            sound.Play();
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);

            if (Stop)
            {
                CancelInvoke("CanonFire");                
            }
        }
        private void Update()
        {
            if (!Stop)
                if (!IsInvoking("CanonFire")){
                    InvokeRepeating("CanonFire", Time1, Delay1);
                }
        }
    }
}

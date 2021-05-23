using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace ShipGame
{
    public class ShipCannon : MonoBehaviour
    {
        public AudioSource sound;
        public KeyCode shootKey = KeyCode.F;
        public GameObject projectile;
        public float shootForce;

        void Update()
        {
            if (Input.GetKeyDown(shootKey))
            {
                sound.Play();
                
                GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
                shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
            }
        }
    }
}
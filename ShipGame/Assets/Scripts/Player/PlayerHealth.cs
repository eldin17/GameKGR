using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace ShipGame
{
    public class PlayerHealth : MonoBehaviour
    {
        public float health = 10;
        public float currentHealth;
        void Start()
        {
            currentHealth = health;
        }
        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.tag == "Mines")
            {
                TakeDamage(health/2);                
                if (currentHealth <= 0)
                    SceneManager.LoadScene(5);
            }
            if (coll.gameObject.tag == "EnemyCannon")
            {
                TakeDamage(1);                
                if (currentHealth <= 0)
                    SceneManager.LoadScene(5);
            }
            if (coll.gameObject.tag == "Health")
            {
                currentHealth = health;                
                Destroy(coll.gameObject);                
            }         
        }
        void TakeDamage(float damage)
        {
            currentHealth -= damage;            
        }
    }
}

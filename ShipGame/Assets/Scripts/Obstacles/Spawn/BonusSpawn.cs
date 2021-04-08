using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame.Obstacles.Spawn 
{   
	public class BonusSpawn : MonoBehaviour
	{
        public GameObject spawnee1;
        public bool stopSpawning1 = false;
        public float spawnTime1;
        public float spawnDelay1;
        
        private void Start()
        {
            InvokeRepeating("SpawnObject1", spawnTime1, spawnDelay1);

        }

        public void SpawnObject1()
        {
            Instantiate(spawnee1, transform.position, transform.rotation);

            if (stopSpawning1)
            {
                CancelInvoke("SpawnObject1");
            }
        }
    }
}

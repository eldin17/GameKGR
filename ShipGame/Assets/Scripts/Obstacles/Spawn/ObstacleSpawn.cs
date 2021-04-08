using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame.Obstacles.Spawn 
{   
	public class ObstacleSpawn : MonoBehaviour
	{
        public GameObject spawnee1;
        public bool stopSpawning1 = false;
        public float spawnTime1;
        public float spawnDelay1;

        public GameObject spawnee2;
        public bool stopSpawning2 = false;
        public float spawnTime2;
        public float spawnDelay2;

        public GameObject spawnee3;
        public bool stopSpawning3 = false;
        public float spawnTime3;
        public float spawnDelay3;

        public GameObject spawnee4;
        public bool stopSpawning4 = false;
        public float spawnTime4;
        public float spawnDelay4;

        public GameObject spawnee5;
        public bool stopSpawning5 = false;
        public float spawnTime5;
        public float spawnDelay5;
        
        private void Start()
        {
            InvokeRepeating("SpawnObject1", spawnTime1, spawnDelay1);
            InvokeRepeating("SpawnObject2", spawnTime2, spawnDelay2);
            InvokeRepeating("SpawnObject3", spawnTime3, spawnDelay3);
            InvokeRepeating("SpawnObject4", spawnTime4, spawnDelay4);
            InvokeRepeating("SpawnObject5", spawnTime5, spawnDelay5);
        }

        public void SpawnObject1()
        {
            Instantiate(spawnee1, transform.position, transform.rotation);

            if (stopSpawning1)
            {
                CancelInvoke("SpawnObject1");
            }
        }
        public void SpawnObject2()
        {
            Instantiate(spawnee2, transform.position, transform.rotation);

            if (stopSpawning2)
            {
                CancelInvoke("SpawnObject2");
            }
        }
        public void SpawnObject3()
        {
            Instantiate(spawnee3, transform.position, transform.rotation);

            if (stopSpawning3)
            {
                CancelInvoke("SpawnObject3");
            }
        }
        public void SpawnObject4()
        {
            Instantiate(spawnee4, transform.position, transform.rotation);

            if (stopSpawning4)
            {
                CancelInvoke("SpawnObject4");
            }
        }
        public void SpawnObject5()
        {
            Instantiate(spawnee5, transform.position, transform.rotation);

            if (stopSpawning5)
            {
                CancelInvoke("SpawnObject5");
            }
        }
    }
}

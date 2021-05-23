using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShipGame
{
    public class NextLevel : MonoBehaviour
    {
        public int nextSceneLoad;
        // Start is called before the first frame update
        void Start()
        {
            nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player"|| other.gameObject.tag == "CannonBall")
            {
                SceneManager.LoadScene(nextSceneLoad);
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
        }        
    }
}

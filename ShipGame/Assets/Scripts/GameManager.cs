using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace ShipGame
{
    public class GameManager : MonoBehaviour
    {
        public float restartDelay = 1f;
        public void EndGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }

    }
}

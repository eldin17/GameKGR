using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShipGame
{
    public class credits : MonoBehaviour
    {
        private void Start()
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusic>().StopMusic();
        }
        public void Quit()
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        public void RestartGame()
        {            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        }
    }
}

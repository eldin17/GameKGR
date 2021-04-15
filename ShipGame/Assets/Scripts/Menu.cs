using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShipGame
{
    public class Menu : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

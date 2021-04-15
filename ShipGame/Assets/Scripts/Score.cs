using UnityEngine;
using UnityEngine.UI;
namespace ShipGame
{
    public class Score : MonoBehaviour
    {
        private float timer;
        private int score;
        public Text scoreText;


        void Update()
        {
            timer += Time.deltaTime;

            if (timer > 1f)
            {

                score++;

                //We only need to update the text if the score changed.
                scoreText.text = score.ToString();

                //Reset the timer to 0.
                timer = 0;
            }
        }
    }
}

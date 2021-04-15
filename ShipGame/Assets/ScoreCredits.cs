using UnityEngine;
using UnityEngine.UI;

namespace ShipGame
{
    public class ScoreCredits : MonoBehaviour
    {
        public Score result;
        public Text score;

        void Update()
        {
            score.text = result.scoreText.text;
        }
    }
}

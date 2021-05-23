using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ShipGame
{
    public class LevelSelection : MonoBehaviour
    {
        public Button[] levelButtons;
        // Start is called before the first frame update
        void Start()
        {
            int levelAt = PlayerPrefs.GetInt("levelAt", 2);
            for (int i=0; i < levelButtons.Length; i++){
                if (i + 2 > levelAt)
                    levelButtons[i].interactable = false;
            }
        }       
    }
}
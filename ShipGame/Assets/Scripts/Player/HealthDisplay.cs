using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ShipGame
{
    public class HealthDisplay : MonoBehaviour
    {
        public PlayerHealth obj;
        public Image healthBar;      

        void Update()
        {
            healthBar.fillAmount = obj.currentHealth/obj.health;
        }
    }
}

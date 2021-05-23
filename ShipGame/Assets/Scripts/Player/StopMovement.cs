using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShipGame.Player 
{   
	public class StopMovement : MonoBehaviour
	{
        public PlayerMovement movement;
        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionInfo.collider.tag == "Enemy")
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }            
        }
    }
}

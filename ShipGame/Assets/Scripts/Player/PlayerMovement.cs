using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame.Player 
{   
	public class PlayerMovement : MonoBehaviour
	{  
	    private void Update()
	    {
			this.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * 30 * Time.deltaTime;
			this.transform.position += new Vector3(0, 0, 5) * 10 * Time.deltaTime;
		}
	}
}

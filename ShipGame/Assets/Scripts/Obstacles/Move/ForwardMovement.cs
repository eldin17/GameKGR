using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShipGame.Obstacles.Move 
{   
	public class ForwardMovement : MonoBehaviour
	{  
	    private void Update()
	    {
			this.transform.position += new Vector3(0, 0, 5) * 10 * Time.deltaTime;
		}
	}
}

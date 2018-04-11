using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour {



	public float hitDistance;

	public bool isGrounded;

	public LayerMask layer;

	DragonController dragonController;



	void Start () {

		dragonController = GetComponent<DragonController> ();
		
	}
	
	void Update () {

		UpdateStats ();

	}



	public void UpdateStats(){


		if (isGrounded) {
		
			hitDistance = 0.35f;

		} else {
		
			hitDistance = 0.15f;

		}

		if (Physics.Raycast (transform.position - new Vector3 (0, 0.95f, 0), -transform.up, hitDistance, layer)) {
		
			isGrounded = true;

			dragonController.dragonJump = false;
		
		} else { 

			isGrounded = false;

		}


	}

}

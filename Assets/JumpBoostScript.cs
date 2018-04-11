using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostScript : MonoBehaviour {


	public Rigidbody player;





	
	
	
	void OnTriggerEnter (Collider col) {
	
		Debug.Log("Hit trigger");
	
		// player = GetComponent<Rigidbody>();
		
		player.AddForce (new Vector3 (0, 20f, 0), ForceMode.VelocityChange);
		
		Destroy (this.gameObject);
		
		
	}
}

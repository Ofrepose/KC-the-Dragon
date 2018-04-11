using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgesScript : MonoBehaviour {


	public Rigidbody player;


	
	
	void OnTriggerEnter (Collider col){
		
		//MAKE CAMERA STOP FOLLOWING CHARACTER WHEN THIS IS HIT		
		
		DragonController.playerFall = true;
		
	}
}

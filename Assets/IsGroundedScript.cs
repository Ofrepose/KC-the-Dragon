using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGroundedScript : MonoBehaviour {


	
	void OnTriggerEnter(){
	
		DragonController.isGrounded = true;


	}
	
	
	void OnTriggerExit(){
	
		DragonController.isGrounded = false;
	
	}
}

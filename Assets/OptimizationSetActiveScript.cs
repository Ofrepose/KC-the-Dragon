using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizationSetActiveScript : MonoBehaviour {

	public GameObject object1;

	public GameObject objectToDisable;


	void Start(){
	
		object1.SetActive (false);
	
	}


	void  OnTriggerEnter(Collider col){

		object1.SetActive (true);

		objectToDisable.SetActive (false);
	}

}

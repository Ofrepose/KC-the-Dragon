using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {



	LevelManager levelmanager;



	void Start () {

		levelmanager = LevelManager.FindObjectOfType<LevelManager> ();
		
	}

	void OnTriggerEnter(Collider col){

		DragonController.died = true;

		Invoke ("Death", 6);

	}


	void Death(){

		levelmanager.LoadLevel ("_Dead");

	}
}

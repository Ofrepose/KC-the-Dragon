using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelScript : MonoBehaviour {


	LevelManager levelmanager;




	void Start () {

		levelmanager = LevelManager.FindObjectOfType<LevelManager> ();
		
	}



	void OnTriggerEnter ( Collider col ){


		levelmanager.LoadLevel ("Level_Done");


	}

}

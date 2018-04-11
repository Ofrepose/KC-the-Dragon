using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour {


	DragonController dragon;

	void Start () {

		dragon = DragonController.FindObjectOfType<DragonController> ();

	}

	
	
	void OnTriggerEnter(Collider col){


		dragon.GetEgg ();

	
		Score.eggsCollected += 1;
		
		Destroy (this.gameObject);

	
	}
}

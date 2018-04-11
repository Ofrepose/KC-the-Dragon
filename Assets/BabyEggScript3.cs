using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyEggScript3 : MonoBehaviour {

	DragonController dragon;


	void Start () {

		dragon = DragonController.FindObjectOfType<DragonController> ();

	}



	void OnTriggerEnter ( Collider col){

		dragon.GetBabyEgg ();

		PlayerPrefs.SetInt ("BabyEgg_3", 1);

		Score.babyEggsCollected += 1; 

		Destroy (this.gameObject);


	}
}

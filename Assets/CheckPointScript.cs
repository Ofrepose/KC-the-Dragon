using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour {

	public GameObject player;

	public Animator textAnimations;

	void Start () {

		Animator textAnimations = GetComponent<Animator> ();
		
	}
	



	void OnTriggerEnter(Collider col){

		textAnimations.SetTrigger ("isCheckPoint");

		PlayerPrefs.SetFloat ("Player_Position_X", player.transform.position.x);

		PlayerPrefs.SetFloat ("Player_Position_Y", player.transform.position.y);

		PlayerPrefs.SetFloat ("Player_Position_Z", player.transform.position.z);

		Destroy (this.gameObject);

	}
}

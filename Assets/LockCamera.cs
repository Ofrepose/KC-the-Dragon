using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour {

	Camera maincamera;

	public Transform player;

	// Use this for initialization
	void Start () {

		maincamera = GetComponent<Camera> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = player.transform.position;

		maincamera.transform.position = new Vector3 (pos.x, transform.position.y, transform.position.z);



		
	}
}

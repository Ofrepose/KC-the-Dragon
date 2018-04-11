using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {



	public Transform followX;

	public Transform player;

	public Transform forY;



	void Start () {
		
	}
	
	void Update () {

		followX.position = new Vector3 (player.position.x, player.position.y + 6f, transform.position.z);

	}
}

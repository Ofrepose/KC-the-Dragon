using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyEggSpawner : MonoBehaviour {


	public GameObject pos1;

	public GameObject pos2;

	public GameObject pos3;

	public GameObject pos4;

	public GameObject pos5;

	public GameObject babyEggPrefab2;

	public GameObject babyEggPrefab3;

	public GameObject babyEggPrefab4;

	public GameObject babyEggPrefab5;

	public GameObject babyEggPrefab;

	//int eggsLeft;





	void Start () {

		Quaternion zero = Quaternion.Euler(0,0,0);

		//eggsLeft = PlayerPrefs.GetInt ("Player_BabyEggs_Left") - PlayerPrefs.GetInt ("Player_BabyEggs");

		if (PlayerPrefs.GetInt ("BabyEgg_1") == 0) {
		
			Vector3 newPos = new Vector3(pos1.transform.position.x,pos1.transform.position.y,pos1.transform.position.z);

			GameObject egg1 = Instantiate(babyEggPrefab, newPos, zero) as GameObject;

		
		}


		if (PlayerPrefs.GetInt ("BabyEgg_2") == 0) {

			Quaternion zero2 = Quaternion.Euler(0,0,0);

			Vector3 newPos2 = new Vector3(pos2.transform.position.x,pos2.transform.position.y,pos2.transform.position.z);

			GameObject egg2 = Instantiate (babyEggPrefab2, newPos2, zero2) as GameObject;

		}



		if (PlayerPrefs.GetInt ("BabyEgg_3") == 0) {


			Quaternion zero3 = Quaternion.Euler(0,0,0);

			Vector3 newPos3 = new Vector3(pos3.transform.position.x,pos3.transform.position.y,pos3.transform.position.z);

			GameObject egg3 = Instantiate (babyEggPrefab3, newPos3, zero) as GameObject;

		}



		if (PlayerPrefs.GetInt ("BabyEgg_4") == 0) {


			Vector3 newPos4 = new Vector3(pos4.transform.position.x,pos4.transform.position.y,pos4.transform.position.z);

			GameObject egg4 = Instantiate (babyEggPrefab4,newPos4, zero) as GameObject;

		}



		if (PlayerPrefs.GetInt ("BabyEgg_5") == 0) {

			Vector3 newPos5 = new Vector3(pos5.transform.position.x,pos5.transform.position.y,pos5.transform.position.z);

			GameObject egg5 = Instantiate (babyEggPrefab5, newPos5, zero) as GameObject;

		}





	














	

		
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreScript : MonoBehaviour {


	public Text endScore;

	public Text endEggs;

	public Text babyEggs;

	int babyEggsCollected;

	int maxBabyEggs = 5;



	void Start () {

		Text endScore = GetComponent<Text> ();

		Text endEggs = GetComponent<Text> ();

		Text babyEggs = GetComponent<Text> ();

		babyEggsCollected = PlayerPrefs.GetInt ("Player_BabyEggs");

		UpdateScreen ();

	}


	void UpdateScreen(){

		endScore.text = "Score: " + PlayerPrefs.GetFloat ("Player_Score").ToString("F0");

		endEggs.text = "Eggs Collected: " + PlayerPrefs.GetInt ("Player_Eggs");

		babyEggs.text = "Baby Eggs Collected: " +  babyEggsCollected.ToString () + " / " + maxBabyEggs;


	}
	

}

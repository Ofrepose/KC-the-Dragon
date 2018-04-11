using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

	
	public Text score;
	
	public Text eggs;

	public Text babyEggs;
	
	public Text lives;
	
	public static bool gameRunning;
	
	float secondsScore;
	
	public static int eggsCollected;

	public static int babyEggsCollected;

	public int maxBabyEggs = 5;



	void Start () {
	
		Text score = GetComponent<Text>();
		
		Text eggs = GetComponent<Text>();

		Text babyEggs = GetComponent<Text> ();

		secondsScore = 	PlayerPrefs.GetFloat ("Player_Score");

		eggsCollected = PlayerPrefs.GetInt ("Player_Eggs");

		babyEggsCollected = PlayerPrefs.GetInt ("Player_BabyEggs");


		//if level 1 have this many baby eggs.!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



		
		//lives = GetComponent<Text>();
		
		
		
	}
	
	void Update () {

		if (DragonController.died || DragonController.playerFall) {
		
			PlayerPrefs.SetFloat ("Player_Score", secondsScore);

			PlayerPrefs.SetInt ("Player_Eggs", eggsCollected);

			PlayerPrefs.SetInt ("Player_BabyEggs", babyEggsCollected);
		
		}
	
		if (gameRunning && !DragonController.died && !DragonController.playerFall){
		
			secondsScore += Time.deltaTime * eggsCollected;
			
			score.text = "Score: " + secondsScore.ToString("F0");	
			
			eggs.text = "Eggs: " + eggsCollected.ToString();	
			
			PlayerPrefs.SetInt ("Player_BabyEggs", babyEggsCollected);
			
			PlayerPrefs.SetInt ("Player_Eggs", eggsCollected);
			
			PlayerPrefs.SetFloat ("Player_Score", secondsScore);

			babyEggs.text = ": " + babyEggsCollected.ToString () + " / " + maxBabyEggs;

		
		
		}


	
		
		
	}
}

 using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public float autoLoadNextLevelAfter;
	
	public void LoadLevel(string name){
	
		//Debug.Log ("this is working for " + name);
		Application.LoadLevel (name);
		
		
	}
	
	void Start(){

		Time.timeScale = 1f;

		if (autoLoadNextLevelAfter > 0){
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}
	
	public void QuitLevel(){
		//Debug.Log ("This is workng for " + name);
		Application.Quit();
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1);
		
		
	}
	
	public void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			LoadLevel("GalaxyMap");
		}
	}


	public void NewGame(){

		PlayerPrefs.SetFloat ("Player_Position_X", -0.7427075f);

		PlayerPrefs.SetFloat ("Player_Position_Y", 28.312f);

		PlayerPrefs.SetFloat ("Player_Position_Z", -5.4f);

		PlayerPrefs.SetFloat ("Player_Score", 0);

		PlayerPrefs.SetInt ("Player_Eggs", 0);

		PlayerPrefs.SetInt ("Player_BabyEggs",0);

		PlayerPrefs.SetInt ("Player_BabyEggs_Left", 5);

		PlayerPrefs.SetInt ("BabyEgg_1", 0);

		PlayerPrefs.SetInt ("BabyEgg_2", 0);

		PlayerPrefs.SetInt ("BabyEgg_3", 0);

		PlayerPrefs.SetInt ("BabyEgg_4", 0);

		PlayerPrefs.SetInt ("BabyEgg_5", 0);

		DragonController.died = false;

		PlayerPrefs.SetInt ("Tutorial", 0);

		PlayerPrefs.SetString ("Current_Level", "DragonAdventure");

		LoadLevel (PlayerPrefs.GetString ("Current_Level"));
		//LoadLevel ("DragonAdventure");


	}

	public void ContinueGame(){
	
		if (PlayerPrefs.GetFloat ("Player_Position_X") != null) {

			PlayerPrefs.SetInt ("Player_Eggs", 0);

			DragonController.died = false;
		
			LoadLevel (PlayerPrefs.GetString ("Current_Level"));
		
		}
	
	}

	public void LoadLevel2(){

		PlayerPrefs.SetString ("Current_Level", "_Level_2");

		PlayerPrefs.SetFloat ("Player_Position_X", -0.7427075f);

		PlayerPrefs.SetFloat ("Player_Position_Y", 28.312f);

		PlayerPrefs.SetFloat ("Player_Position_Z", -5.4f);

		//PlayerPrefs.SetFloat ("Player_Score", 0);

		PlayerPrefs.SetInt ("Player_Eggs", 0);

		PlayerPrefs.SetInt ("Player_BabyEggs",0);

		PlayerPrefs.SetInt ("Player_BabyEggs_Left", 5);

		PlayerPrefs.SetInt ("BabyEgg_1", 0);

		PlayerPrefs.SetInt ("BabyEgg_2", 0);

		PlayerPrefs.SetInt ("BabyEgg_3", 0);

		PlayerPrefs.SetInt ("BabyEgg_4", 0);

		PlayerPrefs.SetInt ("BabyEgg_5", 0);

		DragonController.died = false;
		
	
			LoadLevel ("_Level_2");
		
	

		


	}
	
}
	


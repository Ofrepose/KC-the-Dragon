using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroTutorial : MonoBehaviour {


	public GameObject panel1;

	public GameObject panel2;

	public GameObject panel3;

	public GameObject mainPanel;


	void Start () {

		if (PlayerPrefs.GetInt ("Tutorial") == 0) {

			Time.timeScale = 0f;
		
			mainPanel.SetActive (true);

			panel1.SetActive (true);

			panel2.SetActive (false);

			panel3.SetActive (false);
		
		}







		
	}
	
	void Update () {
		
	}

	public void ClickToContinue(){

		Time.timeScale = 0f;


		panel1.SetActive (false);

		panel2.SetActive (true);

	}

	public void ClickToContinue2(){
		Time.timeScale = 0f;

	
		panel2.SetActive (false);

		panel3.SetActive (true);

	
	}

	public void ClickToFinish(){
	
		mainPanel.SetActive (false);

		Time.timeScale = 1f;

		PlayerPrefs.SetInt ("Tutorial", 1);

	
	}


}

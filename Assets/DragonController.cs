using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour {

	float posx;

	float posy;

	float posz;

	public bool dragonIdle = true;

	public bool dragonJump = false;

	Animator anime;

	public GameObject dragon;

	float dragonSpeed = 4f;

	float direction = 1f;

	float jumpMax = 10f;

	Rigidbody rb;


	//JUMPING

	public static bool isGrounded;
	
	public GameObject boostJump;
	
	public Transform feetForJump;

	int jumpCount = 0;


	//Audio

	private AudioSource jumpSound;

	private AudioSource boostSound;

	private AudioSource eggSound;



	//EGGS

	EggScript eggs;



	//Options Menu

	public GameObject optionsPanel;




	bool isAttacking = false;

	public GameObject dragonShot;

	public Transform dragonMouth;
	
	public static bool died;
	
	public static bool playerFall;





	void Start () {

		posx = PlayerPrefs.GetFloat ("Player_Position_X");

		posy = PlayerPrefs.GetFloat ("Player_Position_Y");

		posz = PlayerPrefs.GetFloat ("Player_Position_Z");

		Vector3 here = new Vector3 (posx, posy, posz);

		transform.position = here;




		Time.timeScale = 1f;

		optionsPanel.SetActive (false);
		
		eggs = GetComponent<EggScript> ();
	
		died = false;
		
		playerFall = false;

		rb = GetComponent<Rigidbody> ();

		anime = GetComponent<Animator> ();

		var aSource = GetComponents<AudioSource> ();

		jumpSound = aSource [0];

		boostSound = aSource [1];

		eggSound = aSource [2];


		
	}
	
	void Update () {

		if (isGrounded && PlayerPrefs.GetInt ("Tutorial") == 1) {

			jumpCount = 0;

		}
	
	
		if(died && !playerFall){
		
			anime.SetTrigger("isDeadRunning");
			Died();
		
		
		}
		
		if (playerFall){
		
			PlayerFallDeath();
		
		}

		if (Input.GetKeyDown(KeyCode.Space) && !died && !playerFall) {

			Attack ();
		
		}

		if (!dragonJump && !dragonIdle && !died && !playerFall && PlayerPrefs.GetInt ("Tutorial") == 1) {
		
			RunningDragon ();
			
		}

		if (!dragonIdle && !died && !playerFall && PlayerPrefs.GetInt ("Tutorial") == 1) {

			RunningDragon ();

		}

		if (!dragonIdle && dragonJump && Input.GetMouseButtonDown (0) && !died && !playerFall && PlayerPrefs.GetInt ("Tutorial") == 1) {

			dragonJump = true;

			JumpDragon ();

		}

		if (!dragonIdle && Input.GetMouseButtonDown (0) && !died && !playerFall && PlayerPrefs.GetInt ("Tutorial") == 1) {

			dragonJump = true;

			JumpDragon ();

		}

		if (dragonIdle && Input.GetMouseButtonDown (0) && !died && !playerFall && PlayerPrefs.GetInt ("Tutorial") == 1) {
		
			Score.gameRunning = true;

			RunningDragon ();
		
		}

	


	


	




		
	}




	public void RunningDragon(){
	
		anime.SetBool ("isIdle", false);

		anime.SetBool ("isFlying", false);

		anime.SetBool ("isRunning", true);

		dragonIdle = false;

		transform.position += Vector3.right * dragonSpeed * Time.deltaTime * direction;
		
	
	}




	public void JumpDragon(){




		anime.SetBool ("isRunning", false);



		dragonJump = false;

		if (!isGrounded && jumpCount == 0){

			anime.SetBool ("isFlying", true);

			boostSound.Play ();

			rb.AddForce (new Vector3 (0, 20f, 0), ForceMode.Impulse);
			
			GameObject boost = Instantiate(boostJump, feetForJump.position, feetForJump.rotation) as GameObject;

			jumpCount += 1;


		}


		if (isGrounded && jumpCount == 0) {

			anime.SetBool ("isFlying", true);

			jumpSound.Play ();
		
			rb.AddForce (new Vector3 (0, 5f, 0), ForceMode.VelocityChange);




		}







	}





	public void Attack(){

		//anime.SetTrigger ("isAttacking");

		Vector3 firePostion = dragonMouth.position;

		GameObject fire = Instantiate (dragonShot, dragonMouth.position, dragonMouth.rotation) as GameObject;
		





	}
	
	
	public void Died(){
	
		rb.AddForce (new Vector3 (0, 0, 0), ForceMode.VelocityChange);
	
	}
	
	
	public void PlayerFallDeath(){
	
		rb.AddForce (new Vector3 (0, 0, 0), ForceMode.VelocityChange);
		
		anime.SetBool("isRunning", false);
	
	}

	public void GetEgg(){
	
		eggSound.Play ();
	
	}



	public void GetBabyEgg(){



	}



	public void ShowOptionsPanel(){

		Time.timeScale = 0f;

		optionsPanel.SetActive(true);

	}



	public void QuitOptionsPanel(){

		Time.timeScale = 1f;

		optionsPanel.SetActive(false);
	}




}

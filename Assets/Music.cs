using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	static Music instance = null;

	int destructNumber;



	public AudioClip[] clips;
	public AudioSource source;
	public float newclip;
	public float timer;

	public AudioSource deadSong;


	void Awake(){

		source = gameObject.AddComponent<AudioSource> ();

		deadSong = GetComponent<AudioSource> ();

		if (instance != null) {
			int destructing = 1;
			Destroy (gameObject);
			destructNumber = destructing + 1;


		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	/*void Start () {
		DontDestroyOnLoad (this.gameObject);

		
		
	}*/
	
	void Update () {
		timer += Time.deltaTime;

		if (timer >= newclip + 1 && !DragonController.died) {
			newCLIP ();
			timer = 0;
		}

		if (DragonController.died) {
		
			PlayDeadSong ();
		}
	}

	void newCLIP(){
		int clipNum = Random.Range (0, clips.Length);
		if (!source.isPlaying) {
			source.loop = true;
			source.PlayOneShot (clips [clipNum]);
		}
		newclip = clips [clipNum].length;
	}

	public void PlayDeadSong(){
	
		//source.Stop ();

		//deadSong.Play ();
	
	}
}

using UnityEngine;
using System.Collections;

public class Siren : MonoBehaviour {

	public SirenState State;

	private AudioSource audio;
	public AudioClip Clip;
	public float Volume;

	private float f;

	// Use this for initialization
	void Start () {

		State = SirenState.Off;
		audio = GetComponent<AudioSource>();  
		f = 0;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Q)) {
			if (State == SirenState.Off) {
				State = SirenState.On;
				f = 0;
				Sound ();
			} else {
				State = SirenState.Off;
			}
		}

		f = f + Time.deltaTime;	
		if(f >= Clip.length && State == SirenState.On){

			Sound ();
			f = 0;
			
		}

	}

	void Sound(){

		this.audio.PlayOneShot (Clip, Volume);
	
	}
	

		public enum SirenState {Off, On};
}

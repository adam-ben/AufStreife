using UnityEngine;
using System.Collections;

public class Emergency : MonoBehaviour {
	
	private float time;
    public float Volume;

	private new AudioSource audio;

	public AudioClip Clip;
	public AudioClip Clip2;

	private bool waitForInput;


	// Use this for initialization
	void Start ()
    {

		this.audio = GetComponent<AudioSource>();
		PlayClipAtTime ();
	
	}
	
	// Update is called once per frame
	void Update ()
    {

		if (waitForInput)
        {
			if(Input.GetKeyDown(KeyCode.Alpha2))
            {

				waitForInput = false;
				ClipFinished();

			}
			
		} 

	}

	void PlayClipAtTime()
    {

		time = Random.Range (10,20);
		Invoke("PlayNow", time);

	}

	void PlayNow()
    {

		this.audio.PlayOneShot(Clip, Volume);
		waitForInput = true;

	}

	void ClipFinished()
    {

	
		this.audio.PlayOneShot(Clip2, Volume);
        Invoke("Action", Clip2.length);


	}

	void Action()
    { 

        //EINSATZ HIER PROGRAMMIEREN

	}

	
}
	



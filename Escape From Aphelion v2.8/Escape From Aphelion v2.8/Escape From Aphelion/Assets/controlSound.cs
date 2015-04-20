using UnityEngine;
using System.Collections;

public class controlSound : MonoBehaviour {

	private static float volume;
	AudioSource audio;
	// Use this for initialization
	void Start () {
	
		volume = PlayerPrefs.GetFloat ("BG_Volume");
		audio = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		volume = PlayerPrefs.GetFloat ("BG_Volume");
		audio.volume = volume;
	}
}

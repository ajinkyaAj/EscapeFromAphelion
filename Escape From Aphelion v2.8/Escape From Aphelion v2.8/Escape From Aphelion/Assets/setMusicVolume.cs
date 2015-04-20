using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setMusicVolume : MonoBehaviour {
	
	public static float volume;
	Slider slider01;
	
	// Use this for initialization
	void Start () {
		
		slider01 = this.gameObject.GetComponent<Slider> ();
		if (PlayerPrefs.HasKey ("SFX_Volume")) {
			slider01.value = PlayerPrefs.GetFloat ("SFX_Volume");
		}
		else {
			volume = slider01.value;
			PlayerPrefs.SetFloat ("SFX_Volume", volume);
			PlayerPrefs.Save();
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		volume = slider01.value;
		PlayerPrefs.SetFloat ("SFX_Volume", volume);
		PlayerPrefs.Save();
	}
	
}

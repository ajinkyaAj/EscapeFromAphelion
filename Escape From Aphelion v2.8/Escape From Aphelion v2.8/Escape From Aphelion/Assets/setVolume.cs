using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class setVolume : MonoBehaviour {

	private static float volume;
	Slider slider01;

	// Use this for initialization
	void Start () {

		slider01 = this.gameObject.GetComponent<Slider> ();
		if (PlayerPrefs.HasKey ("BG_Volume")) {
						slider01.value = PlayerPrefs.GetFloat ("BG_Volume");
				}
		else {
				volume = slider01.value;
				PlayerPrefs.SetFloat ("BG_Volume", volume);
				PlayerPrefs.Save();
		}
			

	}
	
	// Update is called once per frame
	void Update () {
		volume = slider01.value;
		PlayerPrefs.SetFloat ("BG_Volume", volume);
		PlayerPrefs.Save();
	}
	
}

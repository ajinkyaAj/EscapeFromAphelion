
using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class HighScoreTable : MonoBehaviour {
	Text txt;
	int value;
	int count;
	// Use this for initialization
	void Start () {
		count = 0;
		txt = gameObject.GetComponent<Text>();
		txt.text = "High Score \n";
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 10) {
			return;
				}
		for (int i=0; i<10; i++) {
			count ++;
						if (PlayerPrefs.HasKey (i + "Score")) {
								value = PlayerPrefs.GetInt (i + "Score");
								txt.text = txt.text + "\n" + value;
						}
				}
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreText : MonoBehaviour {

	Text txt;
	private int currentscore=0;

	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
		txt.text="Score : " + moveBoxScript.score;
	}
	// Update is called once per frame
	void Update () {
		if (moveBoxScript.score < 0) {
			moveBoxScript.score = 0;
			}
		if (destroyObjScript.highscore < moveBoxScript.score) {
			destroyObjScript.highscore = moveBoxScript.score;
			
		}
		txt.text="Score : " + moveBoxScript.score + System.Environment.NewLine + "High Score : " + destroyObjScript.highscore;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOverScript : MonoBehaviour {


	float timer;
	Text txt;

	//public GUISkin myskin;
	// Use this for initialization
	public GUIStyle style;
	void Start () 
	{
		timer = 0.0f;
	}

	void OnGUI()
	{



		//Application.LoadLevel("GameOver");
		int temp = PlayerPrefs.GetInt ("Player Score");

		string _Content = "Your Score \n"+ temp;
		//GUI.skin = myskin;
		style.fontSize = 33;
	    GUI.Label(new Rect(Screen.width/1.4f, Screen.height/13.0f, Screen.width/5.0f, Screen.height/10.0f),_Content,style);
		//GUI.Label(new Rect(Screen.width/2f, Screen.height/7.0f, Screen.width/5.0f, Screen.height/10.0f),_Content);
		//	GUI.Label (Rect (10, 10, 100, 20), "Hello World!");


	}

	// Update is called once per frame
	void Update () 
	{


		timer += Time.deltaTime;
		if (timer > 3.0) 
		{
			Application.LoadLevel("MainMenu");
		}
	}
}

/*
#pragma strict

var timer = 0.0;

function Start () {
	
}

function Update () {
	timer += Time.deltaTime;
	if(timer > 3.0)
	{
		
		
		Application.LoadLevel("2DTennis");
		
	}
	
} */
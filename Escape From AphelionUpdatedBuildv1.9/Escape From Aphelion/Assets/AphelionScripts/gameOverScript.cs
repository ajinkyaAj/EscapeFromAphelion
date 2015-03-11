using UnityEngine;
using System.Collections;

public class gameOverScript : MonoBehaviour {

	float timer;

	// Use this for initialization
	void Start () 
	{
		timer = 0.0f;
	}

	void OnGUI()
	{

		//Application.LoadLevel("GameOver");
		string _Content = "Seconds Left.." + timer;
		GUI.Label(new Rect(Screen.width/1.2f, Screen.height/13.0f, Screen.width/5.0f, Screen.height/10.0f),_Content);
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
﻿using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/4.1f, Screen.height/2f, Screen.width/4, Screen.height/10),"New Game"))
		{
			Application.LoadLevel("SceneWithRotation");
		}
		
		if(GUI.Button(new Rect(Screen.width/4.1f, Screen.height/1.5f, Screen.width/4, Screen.height/10),"Exit Game"))
		{
			Application.Quit();
		}
		
	}
	
	
	
}

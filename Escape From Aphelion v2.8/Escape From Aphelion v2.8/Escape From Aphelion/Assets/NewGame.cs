﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NewGame : MonoBehaviour {
	
	private Button b;
	void Start () 
	{
		 b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());

	}
	void Update()
	{

	}
	public void Hello()
	{
		LoadingScreen.show ();
		Application.LoadLevel("SceneWithRotation");
	}
	
	
}

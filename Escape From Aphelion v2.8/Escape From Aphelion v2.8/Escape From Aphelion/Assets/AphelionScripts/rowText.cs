﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class rowText : MonoBehaviour {
	Text txt;
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		txt.text = destroyObjScript.powerups[1].ToString();
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class setting : MonoBehaviour {
	public AudioClip[] list;
	private Button b;
	private GameObject go;
	Canvas canvas01;

	void Start () 
	{
		//list = new AudioClip[]{(AudioClip)Resources.Load ("Sounds/menu")};
		b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());

	}
	void Update()
	{
		
	}
	public void Hello()
	{


		LoadingScreen.show ();
		Application.LoadLevel("Intro");
		/*
		go = GameObject.Find ("help_canvas");
		canvas01 = go.GetComponent<Canvas>();
		Application.LoadLevel ("SettingsScreen");
		canvas01.enabled = !canvas01.enabled;

*/
	}
	
	
}

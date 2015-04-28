using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour {
	//public AudioClip[] list;
	private Button b;
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
		//AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
		
		//foreach (GameObject thisSound in GameObject.Find("One shot audio")){
		//GameObject thisSound = GameObject.Find ("One shot audio");
		
		//	}

		for (int i = 0; i < 19; i++) {
			string theName = "shipPart" + (i + 1);
			PlayerPrefs.DeleteKey(theName);
		}

		LoadingScreen.show ();
		Application.LoadLevel("MainMenu");
	}
	
	
}

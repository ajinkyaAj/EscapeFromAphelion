using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HelpScript : MonoBehaviour {
	public AudioClip[] list;
	private Button b;

	// Use this for initialization
	void Start () {
	
		list = new AudioClip[]{(AudioClip)Resources.Load ("Sounds/menu")};
		b = this.GetComponent<Button> ();
		b.onClick.AddListener(() => Hello());

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Hello()
	{
		//AudioSource.PlayClipAtPoint (list[0], transform.position, setMusicVolume.volume);
		
		//foreach (GameObject thisSound in GameObject.Find("One shot audio")){
		//GameObject thisSound = GameObject.Find ("One shot audio");
		
		//	}
		
		LoadingScreen.show ();
		Application.LoadLevel("HelpScreen");
	}
}
